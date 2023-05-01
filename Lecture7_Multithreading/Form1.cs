using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Lecture7_Multithreading
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//Make async
		//Will return a Task<double>
		public async Task<double> AddNumbers(double number1, double number2)
		{
			Stopwatch sw = new Stopwatch();
			int sum = 0;
			sw.Start();
			await Task.Run(() =>
			{
				

				for (int i = 0; i < 5000000; i++)
				{
					Random rand = new Random();
					int randomNum1 = rand.Next(0, 2000);
					Random rand2 = new Random(randomNum1);
					int randomNum2 = rand.Next(0, randomNum1);
					Random rand3 = new Random(randomNum2);
					int randomNum3 = rand.Next(0, randomNum2);

					sum += randomNum1;
				}
				DisplayToRTB("The for loop stopped running");
			});
			sw.Stop();
			DisplayToRTB(sw.ElapsedMilliseconds.ToString());
			return sum;
		}

		//public async void ExampleAsyncReturn()
		//{
		//	Stopwatch sw = new Stopwatch();
		//	sw.Start();
		//	double value = await PerformMath(1, 2);
		//	sw.Stop();

		//	DisplayToRTB($"Time elapsed: {sw.Elapsed.TotalSeconds} : Result: {value}");
		//}
		public void DisplayToRTB(string message)
		{
			rtbDisplay.Text += message + "\n";
		}

		public void LongProcess()
		{
			DisplayToRTB("Long Process Started");
			//This is locking up the main threat that the GUI is on
			Thread.Sleep(6000);
			
			
			DisplayToRTB("Long Process Ended");
		}

		public void ShortProcess()
		{
			DisplayToRTB("Short Process Started");
			


			DisplayToRTB("Short Process Ended");
		}

		private void btnSync_Click(object sender, EventArgs e)
		{
			ShortProcess();
			LongProcess();
			
		}

		//Async is a method modifier - tells computer to run in a special way

		public async void LongAsyncProcess(int number)
		{
			DisplayToRTB($"Long Async started : Thread {number}");

			
			//Replace thread.sleep with async version
			await Task.Delay(4000);
			

			DisplayToRTB($"Long Async ended : Thread {number}");
		}
		

		private void btnAsync_Click(object sender, EventArgs e)
		{
			LongAsyncProcess(1);
			ShortProcess();
		}

		private void btnMultiThread_Click(object sender, EventArgs e)
		{
			for (int i = 0; i < 5; i++)
			{
				LongAsyncProcess(i);
			}
		}

		private async void btnStopwatch_Click(object sender, EventArgs e)
		{
			Stopwatch sw = new Stopwatch();
			//Start
			sw.Start();

			

			await Task.Run(() =>
			{
				Random rand = new Random();

				for (int i = 0; i < 1000000; i++)
				{
					rand.Next(0, 1000000);
				}
				DisplayToRTB("The for loop stopped running");
			});
			

			//Stop
			sw.Stop();

			DisplayToRTB(sw.ElapsedMilliseconds.ToString());
		}

		private async void btnReturnValue_Click(object sender, EventArgs e)
		{
			DisplayToRTB("Before we call async method");
			
			//Use await to let async method return a specific type
			double sum = await AddNumbers(5, 5);

			DisplayToRTB("after we call async method");
			DisplayToRTB(sum.ToString());
		}

		//Callback is a method thats called after another event finishes
		private async void btnCallback_Click(object sender, EventArgs e)
		{
			//Task<int> task = Task.Run(async () =>
			//{
			//	DisplayToRTB("Task is running");
			//	await Task.Delay(3000);
			//	DisplayToRTB("Task is finished");
			//	return 5000;
			//});

			////The argument is passed in, represents the value that is returned from the instanced task
			////You can get the result with the .Result property
			//await task.ContinueWith(returnedValueFromTask =>
			//{
			//	DisplayToRTB("Continue is running");
			//	int sum = returnedValueFromTask.Result + returnedValueFromTask.Result;
			//	DisplayToRTB("Continue is finished");
			//	DisplayToRTB(sum.ToString());
			//});

			Task doubleSum = Task.Run(async () =>
			{
				DisplayToRTB("Start run");
				await Task.Delay(3000); //Delayed task by 3 sec
				return 2.5; //Return value of 2.5
			}).ContinueWith(async t => //Added a callback with .ContinueWith() directly to original task
			{
				DisplayToRTB("Start sum");
				await Task.Delay(3000);
				DisplayToRTB((t.Result * t.Result).ToString()); //Squared the result and returned it

			});
			//int number = await task;

			//DisplayToRTB(number.ToString());
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			rtbDisplay.Text = " ";
		}
	}
}
