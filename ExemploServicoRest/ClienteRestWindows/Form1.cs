﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteRestWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ExibirFornecedores();
        }

        private async void ExibirFornecedores()
        {
            var formato = new MediaTypeWithQualityHeaderValue("application/json");
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:62995/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(formato);
                var resposta = await client.GetAsync("api/Exemplo");
                var conteudo = await resposta.Content.ReadAsAsync<Fornecedor[]>();
                dgv.DataSource = conteudo;
            }
        }
    }
}
