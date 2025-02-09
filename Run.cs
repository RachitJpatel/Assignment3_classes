namespace Assignment3_classes
{
        // FILE: Run.cs
        // DESCRIPTION: Controls the program logic by creating members and displaying their details.

        internal class Run
        {
            // METHOD: StartTheCode
            // DESCRIPTION: Creates member objects, assigns data, and displays results using the UI class.
            public void StartTheCode()
            {
                // Creating an object of UI for displaying output
                UI ui = new UI();
                // Creating 5 Member objects
                Member member1 = new Member();
                Member member2 = new Member();
                Member member3 = new Member();
                Member member4 = new Member();
                Member member5 = new Member();

                // Assigning data to members using SetAllData()
                member1.SetAllData("Rachit", "Patel", "Rp@gmail.com", new DateTime(2005, 3, 29));
                member2.SetAllData("Nirav", "Sean", "NS@gmail.com", new DateTime(1990, 7, 10));
                member3.SetAllData("Yash", "Bhatiya", "Yb@gmail.com", new DateTime(1999, 8, 15));
                member4.SetAllData("Alex", "Clarce", "Ac@gmail.com", new DateTime(2001, 1, 15));
                member5.SetAllData("Linda", "Willam", "Lw@gmail.com", new DateTime(2006, 9, 29));

                // Displaying member details using UI class
                ui.Display($"Member ID: {member1.GetMemberID()}, Name: {member1.GetName()}, Age: {member1.CalculateAge()}");
                ui.Display($"Member ID: {member2.GetMemberID()}, Name: {member2.GetName()}, Age: {member2.CalculateAge()}");
                ui.Display($"Member ID: {member3.GetMemberID()}, Name: {member3.GetName()}, Age: {member3.CalculateAge()}");
                ui.Display($"Member ID: {member4.GetMemberID()}, Name: {member4.GetName()}, Age: {member4.CalculateAge()}");
                ui.Display($"Member ID: {member5.GetMemberID()}, Name: {member5.GetName()}, Age: {member5.CalculateAge()}");
            }
        }
    
}