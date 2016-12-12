using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Media;

namespace SambaClient
{
    class ImageListViewAdapter : BaseAdapter<Image>
    {
        private List<Image> mItems;
        private Context mContext;

        public ImageListViewAdapter(Context context, List<Image> items)
        {
            mContext = context;
            mItems = items;
        }

        public override Image this[int position]
        {
            get
            {
                return mItems[position];
            }
        }

        public override int Count
        {
            get
            {
                return mItems.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(mContext).Inflate(Resource.Layout.ListView_Row, null, false);
            }

            ImageView imgView = row.FindViewById<ImageView>(Resource.Id.imageView1);
            //imgView.SetImageResource(mItems[position]);
            using (var imageView = imgView.FindViewById<ImageView>(Resource.Id.imageView1))
            {
                //string url = Android.Text.Html.FromHtml(item.thumbnail).ToString();
            }

                //var imageUri = ContentUris.WithAppendedId(ContactsContract.Contacts.ContentUri, mItems[position].Id);
                //var contactPhotoUri = Android.Net.Uri.WithAppendedPath(contactUri,
                //    Contacts.Photos.ContentDirectory);
                //contactImage.SetImageURI(contactPhotoUri);

                return row;
        }
    }
}