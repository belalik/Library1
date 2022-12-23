using System;
using System.Collections.Generic;
using System.Text;

namespace Library1
{
    // Κλάση Video, κληρονομεί από την κλάση Item 
    class Video : Item
    {
        // Property Duration - συγκεκριμένο μόνο για αντικείμενα τύπου Video. 
        public int Duration { get; set; }

        // Με κάθε δημιουργία αντικειμένου Video - καλώ τον base constructor (του Item)
        // δίνοντας το title σαν παράμετρο (αφού μόνο αυτήν την παράμετρο περιμένει ο 
        // constructor του Item).  Αφου κληθεί ο base constructor, προχωρώ στην πιο συγκεκριμένη
        // ενέργεια που αφορά το κάθε νέο Video - συγκεκριμένα, δίνω τιμή στην Property Duration. 

        public Video(string title, int duration)
            : base(title)
        {

            Duration = duration;
        }

    }
}
