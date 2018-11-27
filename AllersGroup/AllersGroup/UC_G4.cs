﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace AllersGroup
{
    public partial class UC_G4 : UserControl
    {
        private Consult model;
        private Dictionary<string, double> percentages;
        public List<List<List<String>>> clusters;

        public UC_G4()
        {
            InitializeComponent();

            percentages = new Dictionary<string, double>();
            percentages.Add("10%", 0.1);
            percentages.Add("20%", 0.2);
            percentages.Add("30%", 0.3);
            percentages.Add("40%", 0.4);
            percentages.Add("50%", 0.5);
            percentages.Add("60%", 0.6);
            percentages.Add("70%", 0.7);
            percentages.Add("80%", 0.8);
            percentages.Add("90%", 0.9);


            comboBox1.Items.AddRange(percentages.Keys.ToArray());

            button1.Visible = button2.Visible = true;

            label1.Visible =  label22.Visible = false;
            label23.Visible  = label27.Visible = label28.Visible = false;
            label35.Visible = label36.Visible = label37.Visible = label39.Visible = false;
        }

        public void LoadModel(Consult model)
        {
            this.model = model;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            double percentage = percentages[comboBox1.SelectedItem.ToString()];
            model.Clustering(percentage);
            clusters = model.clusterResult;

            LoadListViewGroups();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Visible = true;
            label1.Text = "Porcentaje : " + comboBox1.SelectedItem.ToString();

            label1.Visible = true;
        }

        private void LoadListViewGroups()
        {

            for (int i = 0; i < clusters.Count(); i++)
            {
                ListViewItem list = new ListViewItem("Grupo: " + (i + 1));
                listView1.Items.Add(list);
            }


        }

        private void Load_ClientsProducts(int pos)
        {
            listView2.Items.Clear();
            listView3.Items.Clear();

            List<List<string>> clusterPos = clusters.ElementAt(pos);

            for (int i = 0; i < clusterPos.ElementAt(0).Count(); i++)
            {
                ListViewItem list = new ListViewItem(clusterPos.ElementAt(0).ElementAt(i).TrimEnd('.'));

                listView2.Items.Add(list);
            }

            for (int i = 0; i < clusterPos.ElementAt(1).Count(); i++)
            {
                ListViewItem list = new ListViewItem(clusterPos.ElementAt(1).ElementAt(i));
                list.SubItems.Add(model.context.Items[int.Parse(clusterPos.ElementAt(1).ElementAt(i))].Name);
                listView3.Items.Add(list);
            }
        }

        //Cargar
        private void button2_Click(object sender, EventArgs e)
        {

            int pos  = listView1.SelectedItems[0].Index;
            label19.Text = "Grupo " + (pos+1);
            label19.Visible = true;

            label28.Text = model.Clustering_ClientWithMostTransactions(clusters.ElementAt(pos))[0];
            label23.Text = model.Clustering_ClientWithMostTransactions(clusters.ElementAt(pos))[1];

            label27.Text = model.Clustering_ClientWithLeastTransactions(clusters.ElementAt(pos))[0];
            label22.Text = model.Clustering_ClientWithLeastTransactions(clusters.ElementAt(pos))[1];

            string lab39 = model.Clustering_ClientWithMostSells(clusters.ElementAt(pos))[1];
            lab39 = string.Format("{0:###,###,###,##0.00##}", Decimal.Parse(lab39));

            label35.Text = model.Clustering_ClientWithMostSells(clusters.ElementAt(pos))[0];
            label39.Text = "$ " + lab39;

            string lab36 = model.Clustering_ClientWithLeastSells(clusters.ElementAt(pos))[1];
            lab36 = string.Format("{0:###,###,###,##0.00##}", Decimal.Parse(lab36));

            label37.Text = model.Clustering_ClientWithLeastSells(clusters.ElementAt(pos))[0];
            label36.Text = "$ " + lab36;



            label28.Visible = label23.Visible = label27.Visible = label22.Visible = true;
            label20.Visible = label21.Visible = label25.Visible = label26.Visible = true;           
            label35.Visible = label36.Visible = label37.Visible = label39.Visible = true;


            Load_ClientsProducts(pos);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Visible = true;
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
