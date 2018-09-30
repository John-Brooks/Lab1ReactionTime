/* Author: John Brooks (johnbrooks@oakland.edu)
 * Date: 09/30/18
 * Copyright 2018 John Brooks
 * MIT License (https://opensource.org/licenses/MIT)
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int trial = 0;
        double min_error, max_error, avg_error;
        List<double> error_list = new List<double>();
        bool running = true;
        int full_progress_pixels = 0;
        

        System.DateTime start = new System.DateTime();
        System.DateTime stop = new System.DateTime();
        System.DateTime last = new System.DateTime();


        public Form1()
        {  
            InitializeComponent();
            tmrMain.Enabled = false;
            full_progress_pixels = panel1.Width;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            start = System.DateTime.Now;
            stop = start.AddSeconds((double)numSeconds.Value);
            tmrMain.Enabled = true;
            running = true;
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {

            double ms_elapsed = (System.DateTime.Now.Ticks - start.Ticks) / System.TimeSpan.TicksPerMillisecond;
            double percentage = ms_elapsed / (double)(numSeconds.Value * 1000);

            if (percentage > 1.75) //what are you doin man
            {
                panel1.Width = full_progress_pixels;
            }
            else
                panel1.Width = (int)(percentage * full_progress_pixels);

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            panel1.Width = 0;
            lbResults.Items.Clear();
            min_error = 0;
            max_error = 0;
            avg_error = 0;
            UpdateLabels();
            tmrMain.Enabled = false;

        }

        private void UpdateLabels()
        { 
            lblAverageError.Text = Math.Round(avg_error).ToString() + " ms";
            lblMaxError.Text = Math.Round(max_error).ToString() + " ms";
            lblMinError.Text = Math.Round(min_error).ToString() + " ms";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (!running)
                return;
            trial++;
            System.DateTime now = new System.DateTime();
            now = System.DateTime.Now;

            double error_ms = (stop.Ticks - now.Ticks) / System.TimeSpan.TicksPerMillisecond;
            error_ms *= -1; //this makes postive error a measure of delay, and negative error being early.

            if (error_ms < min_error)
                min_error = error_ms;
            else if (error_ms > max_error)
                max_error = error_ms;

            error_list.Add(error_ms);
            double error_sum = 0;
            
            foreach (double lc_error in error_list) 
            {
                error_sum += Math.Abs(lc_error);
            }
            avg_error = error_sum / trial;

            UpdateLabels();
            lbResults.Items.Add(Math.Round(error_ms).ToString() + " ms");

            tmrMain.Enabled = false;

        }
    }
}
