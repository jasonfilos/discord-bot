﻿/*
 * Created by SharpDevelop.
 * User: Jason
 * Date: 4/7/2020
 * Time: 10:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

namespace Discord_Bot
{
	
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			for (int i = 0; i < 1000; i++) 
			{
				/*
				Step1 : pls fish
				 */
				
				double randNormal = generateGaussian(12,2);
				int t1 = 1000*(int)randNormal;
				
				Thread.Sleep(t1);
				SendKeys.SendWait("pls fish~");
				
				/*
				Step2 : pls beg
				 */			
				
				double randNormal2 = generateGaussian(10,2);
				int t2 = 1000*(int)randNormal2;
					
				Thread.Sleep(t2);
				SendKeys.SendWait("pls beg~");

				/*
				Step3 : pls trivia
				 */			
				
				double randNormal3 = generateGaussian(10,2);
				int t3 = 1000*(int)randNormal3;
					
				Thread.Sleep(t3);
				SendKeys.SendWait("pls trivia~");
			
				/*
				Step3.5 : answer trivia (a/b/c/d)
				 */		
				
				double randNormal4 = generateGaussian(6,1);
				int t4 = 1000*(int)randNormal4;
				
				Thread.Sleep(t4);
				Random randtest = new Random();
				double test = randtest.NextDouble();
				if (test >= 0 & test < 0.25)
				{
					SendKeys.SendWait("a~");
				}
				else if (test >= 0.25 & test < 0.5)
				{
					SendKeys.SendWait("b~");
				}
				else if (test >= 0.5 & test < 0.75)
				{
					SendKeys.SendWait("c~");
				}
				else if (test >= 0.75 & test < 1.0)
				{
					SendKeys.SendWait("d~");
				}
				else
				{
					SendKeys.SendWait("a~");
				}
				
				/*
				Step4 : pls beg
				 */		
				
				double randNormal5 = generateGaussian(20,3);
				int t5 = 1000*(int)randNormal5;
					
				Thread.Sleep(t5);
				SendKeys.SendWait("pls beg~");		
				
				/*
				Step5 : Use object (bread, candy, chill pill, cookie)
				 */		
				
				double randNormal6 = generateGaussian(6,1);
				int t6 = 1000*(int)randNormal6;
				
				Thread.Sleep(t6);
				Random randtest2 = new Random();
				double test2 = randtest2.NextDouble();
				if (test2 >= 0 & test2 < 0.25)
				{
					SendKeys.SendWait("pls use bread~");
				}
				else if (test2 >= 0.25 & test2 < 0.5)
				{
					SendKeys.SendWait("pls use candy~");
				}
				else if (test2 >= 0.5 & test2 < 0.75)
				{
					SendKeys.SendWait("pls use chill~");
				}
				else if (test2 >= 0.75 & test2 < 1.0)
				{
					SendKeys.SendWait("pls use cookie~");
				}
				else
				{
					SendKeys.SendWait("pls use candy~");
						
				}
				
				double randNormal7 = generateGaussian(3,1);
				int t7 = 1000*(int)randNormal7;
					
				Thread.Sleep(t7);
				SendKeys.SendWait("pls gamble 10~");		

								
			}
			
		}
		public double generateGaussian(int mu, int sigma)
		{
			Random rand = new Random();
			double u1 = 1.0-rand.NextDouble(); //uniform(0,1] random doubles
			double u2 = 1.0-rand.NextDouble();
			double randStdNormal = Math.Sqrt(-2.0 * Math.Log(u1)) * Math.Sin(2.0 * Math.PI * u2); //random normal(0,1)
			return( mu + sigma * randStdNormal); //random normal(mean,stdDev^2)
		}
		public string parseLine(string line)
		{
			return Regex.Replace(line, "[^.0-9]", string.Empty);
		}
		public void runCommand(string command, int mu, int sigma)
		{
				double randNormal = generateGaussian(mu,sigma);
				int t = 1000*(int)randNormal;
				Thread.Sleep(t);
				SendKeys.SendWait(command+"~");
		}

		void Button1Click(object sender, EventArgs e)
		{
//			textBox2.Text = string.Empty;
//			textBox3.Text = string.Empty;
//			double test = generateGaussian(20,5);
//			//label1.Text = test.ToString();
//			//label1.Text=textBox1.Text;
//			label1.Text = "Bot Running!";
//			if (test < 0.5 & test > 0.25)
//			{
//				label1.Text = test.ToString();
//			}
//			for (int i = 0; i < textBox1.Lines.Length; i++)
//			{
//    			textBox2.Text += textBox1.Lines[i].Split(';')[0]+ "\r\n";
//    			//textBox3.Text += Regex.Replace(textBox1.Lines[i],"[^.0-9]", string.Empty) + "\r\n";
//    			textBox3.Text += "mu = " + parseLine(textBox1.Lines[i].Split(',')[0])+ ", ";
//    			textBox3.Text += "sigma = " + parseLine(textBox1.Lines[i].Split(',')[1])+ "\r\n";
			//}
			//Thread.Sleep(5000);
			//runCommand("pls fish",1,1);


		}
	}	
}

	
	
	