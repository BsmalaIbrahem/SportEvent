using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Enums
{
    public enum PointActionType
    {
        [Display(Name = "Ticket Booking")]
        TicketBooking = 1,
        [Display(Name = "Correct Prediction")]
        CorrectPrediction = 2,
        [Display(Name = "Exact Result")]
        ExactResult = 3
    }
}
