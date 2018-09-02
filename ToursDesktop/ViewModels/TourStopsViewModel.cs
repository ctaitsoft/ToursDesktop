using ToursDesktop.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace ToursDesktop.ViewModels {
	public class TourStopsViewModel : INotifyPropertyChanged {

		public TourStopsViewModel() {

			this.TourStops =  Models.TourSource.TourStops;
		}



		public void SelectionChanged(object sender, SelectionChangedEventArgs e) {
		//	this.SelectedTour = e.AddedItems as TourStop;
		}

		public TourStop SelectedTour { get; set; }

		public ObservableCollection<TourStop> TourStops { get; set; }

		public event PropertyChangedEventHandler PropertyChanged;
	}
}
