using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using Android.Media;
using System.IO;

namespace SambaClient
{
    [Activity(Label = "SambaClient", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private List<Image> mItems;
        private ListView mListView;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);

            mListView = FindViewById<ListView>(Resource.Id.listViewFiles);
            

            mItems = new List<Image>();
            //mItems.Add(new Image());

            DirectoryInfo dir = new DirectoryInfo(@"c:\pic");
            //foreach (FileInfo file in dir.GetFiles())
            //{
            //    try
            //    {
            //        this.imageList1.Images.Add(Image.FromFile(file.FullName));
            //    }
            //    catch
            //    {
            //        Console.WriteLine("This is not an image file");
            //    }
            //}

            mListView.Adapter = new ImageListViewAdapter(this, mItems);
            mListView.Adapter = new ArrayAdapter<Image>(this, Resource.Layout.ListView_Row, mItems);

        }
    }
}

