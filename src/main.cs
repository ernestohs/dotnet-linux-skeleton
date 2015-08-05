using System;
using Gtk;

public class Bush : Application {
	static string msg = "(void)";

	public static void Main (string[] args)
	{
		if (args.Length > 0)
			msg = args [0];

		Init ();
		Window w = new Window ("Bush project");
		w.DefaultHeight = 200;
		w.DefaultWidth = 250;
		w.DeleteEvent += new DeleteEventHandler (OnDelete);
		Button b = new Button (msg);
		b.Clicked += new EventHandler (OnClick);
		w.Add (b);
		w.ShowAll ();
		Run ();
	}

	static void OnClick (object obj, EventArgs args)
	{
		Console.WriteLine (msg);
	}

	static void OnDelete (object obj, DeleteEventArgs args)
	{
		Quit ();
	}
}

