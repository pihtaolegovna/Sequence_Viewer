using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Wpf.Ui.Controls;

namespace Sequence_Viewer
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : UiWindow
	{
		public MainWindow()
		{
			InitializeComponent();

			Player.LoadedBehavior = MediaState.Manual;
			Player.Source = new Uri("C:/Users/pihta/Pictures/Forest in Mist.jpg", UriKind.Absolute);
			Player.Play();
		}

		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			(new Auth()).Show();
			this.Close();
		}
	}
}
