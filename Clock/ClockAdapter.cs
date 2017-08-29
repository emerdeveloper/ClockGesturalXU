using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;

namespace Clock
{
    public class ClockAdapter : FragmentPagerAdapter
    {
        //field to store a collection of fragments 
        Android.Support.V4.App.Fragment[] fragments;

        //constructor needs to chain to this base constructor and pass the manager
        public ClockAdapter(
            Android.Support.V4.App.FragmentManager fragmentManager, 
            Android.Support.V4.App.Fragment[] fragments) : base(fragmentManager)
        {
            this.fragments = fragments;
        }

        //Number of Fragments in the collection
        public override int Count
        {
            get { return fragments.Length; }
        }

        public override Android.Support.V4.App.Fragment GetItem(int position)//It receives an integer which identifies the fragment that is being requested by the ViewPager.
        {
            //Use that integer as an index into your fragment collection to return the appropriate one.
            return fragments[position];
        }
    }
}