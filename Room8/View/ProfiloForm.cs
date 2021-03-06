﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Room8.View
{
    public partial class ProfiloForm : Form
    {
        public ProfiloForm()
        {
            InitializeComponent();
        }

		public Button ConfermaButton
		{
			get { return _confermaButton; }
		}

		public TextBox NomeTextBox
		{
			get { return _nomeTextBox; }
		}

		public TextBox CognomeTextBox
		{
			get { return _cognomeTextBox; }
		}

		public TextBox MailTextBox
		{
			get { return _mailTextBox; }
		}

		public TextBox VecchiaPassword
		{
			get { return _vecchiaPasswordTextBox; }
		}

		public TextBox NuovaPassword
		{
			get { return _nuovaPasswordTextBox; }
		}

		public TextBox ConfermaPassword
		{
			get { return _confermaNuovaPasswordTextBox; }
		}

		public TextBox TelefonoTextBox
		{
			get { return _telefonoTextBox; }
		}

		public PictureBox PictureBox
		{
			get { return _pictureBox; }
		}

		public Button FotoButton
		{
			get { return _fotoButton; }
		}

		public Label FileLabel
		{
			get { return _fileLabel; }
		}

		public Label AccountLabel
		{
			get { return _registratiLabel; }
		}

		public OpenFileDialog OpenFileDialog
		{
			get { return _openFileDialog; }
		}

		public ErrorProvider ErrorProvider
		{
			get { return _errorProvider; }
		}
    }
}
