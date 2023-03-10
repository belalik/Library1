using System;

namespace Library1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****************************");
            Console.WriteLine("*  WELCOME TO OUR LIBRARY  *");
            Console.WriteLine("****************************");
            Console.WriteLine("Testing loans, returns, messages etc: \n\n");

            Library aegeanLibrary = new Library(5);

            // Ας φτάξουμε μερικούς χρήστες

            User user1 = new User("Thomas", "thomas@something.com");
            User user2 = new User("Babis", "babis@aegean.gr");
            User user3 = new User("Maria", "maria@something.com");
            User user4 = new User("Mitsos", "mitsos@something.com");

            // Ας προσθέσουμε αυτούς τους χρήστες στην βιβλιοθήκη χρησιμοποιώντας το Property Users, και 
            // εφόσον αυτό είναι λίστα, χρησιμοποιώ την μέθοδο Add της λίστας που προσθέτει το αντικείμενο. 
            aegeanLibrary.Users.Add(user1);
            aegeanLibrary.Users.Add(user2);
            aegeanLibrary.Users.Add(user3);
            aegeanLibrary.Users.Add(user4);



            // Ας φτιάξουμε μερικά Items (Books)

            Book book1 = new Book("1984", "George Orwell");
            Book book2 = new Book("War and Peace", "Leo Tolstoy");
            Book book3 = new Book("Tale of two Cities", "Charles Dickens");
            Book book4 = new Book("The Gambler", "Fyodor Dostoevsky");
            Book book5 = new Book("Crime and Punishment", "Fyodor Dostoevsky");
            Book book6 = new Book("Don Quixote", "Miguel de Cervantes");
            Book book7 = new Book("C# for Programmers", "Deitel & Deitel");
            Book book8 = new Book("The Art of Computer Programming", "Donald Knuth");

            // Περνάω τα Items (Books) μέσα στη λίστα Items. 
            aegeanLibrary.Items.Add(book1);
            aegeanLibrary.Items.Add(book2);
            aegeanLibrary.Items.Add(book3);
            aegeanLibrary.Items.Add(book4);
            aegeanLibrary.Items.Add(book5);
            aegeanLibrary.Items.Add(book6);
            aegeanLibrary.Items.Add(book7);
            aegeanLibrary.Items.Add(book8);



            // Φτιάχνω Video και τα περνάω στην λίστα με τα Items. 

            Video video1 = new Video("Queen - Live 8", 24);
            Video video2 = new Video("Pink Floyd: Live at Pompeii", 64);
            Video video3 = new Video("Johnny Cash Live at San Quentin", 60);
            Video video4 = new Video("Aretha Live at Fillmore West", 90);
            Video video5 = new Video("The Godfather", 170);
            Video video6 = new Video("American Beauty", 122);

            aegeanLibrary.Items.Add(video1);
            aegeanLibrary.Items.Add(video2);
            aegeanLibrary.Items.Add(video3);
            aegeanLibrary.Items.Add(video4);
            aegeanLibrary.Items.Add(video5);
            aegeanLibrary.Items.Add(video6);


            // Ας φτιάξω και μερικά Journals

            Journal journal1 = new Journal("Cyclades Journal", "Serious Mag");
            Journal journal2 = new Journal("Review of Psychology", "Harvard University");
            Journal journal3 = new Journal("Review of Sociology", "Harvard University");
            Journal journal4 = new Journal("Trends in Design", "DPSD");
            Journal journal5 = new Journal("Cultural Heritage", "DPSD");
            Journal journal6 = new Journal("Interactive Systems", "DPSD");


            // Προσοχή - για τα journals χρησιμοποιώ μια μέθοδο, και δεν κάνω σκέτο .Add .. 
            // ΤΟ ΑΠΟΤΕΛΕΣΜΑ ΕΙΝΑΙ ΤΟ ΙΔΙΟ - το κάνω απλώς σαν παράδειγμα.  Διαβάστε τα σχόλια στην 
            // μέθοδο AddItem της κλάσης Library.
            aegeanLibrary.AddItem(journal1);
            aegeanLibrary.AddItem(journal2);
            aegeanLibrary.AddItem(journal3);
            aegeanLibrary.AddItem(journal4);
            aegeanLibrary.AddItem(journal5);
            aegeanLibrary.AddItem(journal6);



            // Ας δανείσουμε μερικά Items σε Χρήστες (φτιάχνοντας τα αντίστοιχα Loan αντικείμενα - και περνώντας τα στην Λίστα Loans του aegeanLibrary). 

            /*
             *  Ο χρήστης user1 δανείζεται το Item book1, με ημερομηνία δανεισμού την 15η Δεκεμβρίου 2022.
             *  για την ημερομηνία, Χρησιμοποιώ την κλάση DateTime από τις βιβλιοθήκες της C#, 
             *  και συγκεκριμένα τον constructor: public DateTime (int year, int month, int day).  
             *  
             *  Με άλλα λόγια, φτιάχνω και περνάω σαν παράμετρο
             *  ένα νέο DateTime object, δίνοντας τιμές για έτος, μήνα και μέρα. 
             *  
             *  (*) - Προσοχή στην σειρά των παραμέτρων, πρώτα έτος, μετά μήνας, μετά μέρα. 
             *  
             *  (Η DateTime έχει πολλούς διαθέσιμους constructors, περισσότερες πληροφορίες εδώ: 
             *  
             *  https://docs.microsoft.com/en-us/dotnet/api/system.datetime.-ctor?view=netframework-4.7.2
             *  
             */
            aegeanLibrary.LoanItem(user1, book1, new DateTime(2022, 12, 15));

            // Με την ίδια λογική, φτιάχνω ακόμα 3 "δανεισμούς" για τον χρήστη user1: 

            // 22 Νοεμβρίου 2022
            aegeanLibrary.LoanItem(user1, book3, new DateTime(2022, 11, 22));

            // 19 Δεκεμβρίου 2022
            aegeanLibrary.LoanItem(user1, book4, new DateTime(2022, 10, 19));

            // 20 Νοεμβρίου 2022
            aegeanLibrary.LoanItem(user1, video1, new DateTime(2022, 11, 20));

            // και άλλον έναν ...

            // Σε αυτό το αντικείμενο χρησιμοποιώ το (public) Property της DateTime 'Now' που κάθε φορά
            // μου δίνει ένα αντικείμενο DateTime με ημερομηνία και ώρα "Now" - δηλαδή ορισμένο 
            // για την στιγμή που τρέχει η εφαρμογή μου. 
            aegeanLibrary.LoanItem(user1, video2, DateTime.Now);


            // Εδώ θα προσπαθήσω να δανείσω άλλο ένα αντικείμενο (το Journal1) 
            // στον χρήστη user1 - όμως ο δανεισμός δεν θα γίνει, και θα τυπωθεί 
            // κατάλληλο μήνυμα γιατί ο χρήστης έχει ήδη συμπληρώσει το μέγιστο 
            // αριθμό δανεισμένων αντικειμένων (έχει ήδη 5 loans). 

            aegeanLibrary.LoanItem(user1, journal1, new DateTime(2022, 11, 29));

            // Ο χρήστης user2 έχει δανειστεί το book2 την ημερομηνία 18/12/2022
            aegeanLibrary.LoanItem(user2, book2, new DateTime(2022, 12, 18));

            // Ο χρήστης user2 προσπαθεί να δανειστεί το book1 αλλά δεν θα μπορέσει 
            // (θα τυπωθεί κατάλληλο μήνυμα) γιατί το book1 το έχει ήδη πάρει ο χρήστης user1
            // (το onLoan είναι true). 
            aegeanLibrary.LoanItem(user2, video2, DateTime.Now);

            // Ο χρήστης user2 έχει δανειστεί το journal5 με ημερομηνία 21/12/2022
            aegeanLibrary.LoanItem(user2, journal1, new DateTime(2022, 12, 21));


            // Είδαμε πιο πάνω πως ο user1 θέλει να πάρει το journal1 αλλά δεν μπορεί επειδή έχει 
            // ήδη δανειστεί 5 Items.  Ας υποθέσουμε πως επιστρέφει το book1 που είχε πάρει. 
            // Δοκιμάζω την μέθοδο Return που χειρίζεται τις επιστροφές. 
            aegeanLibrary.Return(user1, book1);

            // Για να δω τώρα αν μπορεί όντως να πάρει το journal1 που δοκίμασα και πιο πριν και δεν μπορούσε 
            aegeanLibrary.LoanItem(user1, journal1, DateTime.Now);

            // *** Θα δω πως δεν μπορεί, γιατί το έχει ήδη πάρει ο χρήστης user2 !!! ***
            // Μην μπερδευτείτε που οι ημερομηνίες μπορεί να μην είναι πολύ λογικές, δεν έχουμε 
            // πραγματικό σενάριο, αλλά απλώς προθέτουμε/αφαιρούμε δανεισμούς για να ελέγξουμε την λειτουργία!

            // Ο χρήστης user2 επιστρέφει το journal1. 
            aegeanLibrary.Return(user2, journal1);

            // επιτέλους, ο χρήστης user1 θα πάρει το journal1 που τόσο ήθελε. 
            aegeanLibrary.LoanItem(user1, journal1, DateTime.Now);


            // Μια τελευταία δοκιμή του Return, είναι να δοκιμάσει ένας χρήστης να επιστρέψει κάποιο Item 
            // που δεν βρίσκεται στην κατοχή του. 
            aegeanLibrary.Return(user3, journal1);

            // Μια ακόμα δοκιμή είναι ένας χρήστης να δοκιμάσει να επιστρέψει κάτι που δεν είναι δανεισμένο
            // από κανέναν
            aegeanLibrary.Return(user1, video6);

            // Ας τυπώσουμε όλα τα Items κάθε φορά με άλλη μέθοδο 
            // 
            // μπορείτε να επιλέξτε και μια μέθοδο κάθε φορά, βάζοντας τις υπόλοιπες σε comments 

            /*aegeanLibrary.ShowAllItems();
          
            aegeanLibrary.ShowAllItems2();
           
            aegeanLibrary.ShowAllItems3();*/

            aegeanLibrary.ShowAllItems4();


            // OK ... ας προσθέσω ένα-δυο ακόμα late loans (δηλαδή με παλιές ημερομηνίες) για να χρησιμοποιήσω και την 
            // μέθοδο που τυπώνει τα πρόστιμα ... 


            // Ο χρήστης user3 (Maria) είχε πάρει το video5 από τις 20 Οκτωβρίου ...  Τα βίντεο θεωρούνται late
            // μετά από μόλις μια εβδομάδα.. Το πρόστιμο θα είναι μεγάλο!
            aegeanLibrary.LoanItem(user3, video5, new DateTime(2022, 10, 20));

            Console.WriteLine();
            aegeanLibrary.ShowOverdueLoans();
        }

    }
}
