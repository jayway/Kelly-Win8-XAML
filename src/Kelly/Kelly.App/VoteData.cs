using Kelly.App.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Windows.ApplicationModel;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace Kelly.App
{
    public class VoteData : BindableBase
    {
        public VoteData()
        {
            if (DesignMode.DesignModeEnabled)
            {
                VotePercentage = 0.7;
                Fill = new SolidColorBrush(Colors.Yellow);
                NbrVotes = 17;
            }
        }

        public int NbrVotes { get; set; }
        public double VotePercentage { get; set; }
        public double RestPercentage { get { return 1 - VotePercentage; } }
        public Brush Fill { get; set; }
    }
}
