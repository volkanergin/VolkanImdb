using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YMS5573_VolkanIMDB_Project
{
    public partial class MemberHome : Form
    {
        public MemberHome()
        {
            InitializeComponent();
        }

        private void lnkWriteAReview_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception)
            {

                MessageBox.Show("Unable to open link that was clicked.");
            }
        }

        private void VisitLink()
        {
            lnkWriteAReview.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/chart/top");
        }

        private void lnkYourAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkYourAccount.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/registration/accountsettings");
        }

        private void lnkLists_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkLists.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/user/ur1845639/lists");
        }

        private void lnkCheckIns_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkCheckIns.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/user/ur4268539/checkins");

        }

        private void lnkEditProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkEditProfile.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/activity/editprofile");
        }

        private void lnkAboutThisPage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkAboutThisPage.LinkVisited = true;

            System.Diagnostics.Process.Start("https://help.imdb.com/article/imdb/general-information/faq-for-the-your-activity-feature/GJSRJTR7G24USEPC?ref_=cons_urprof_prof#");

        }

        private void lnkRatings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkRatings.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/user/ur1584229/ratings");
        }

        private void lnkWatchlist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkWatchlist.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/user/ur53345246/watchlist");

        }

        private void lnkReviews_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkReviews.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/user/ur8714798/reviews");

        }

        private void lnkPollResponses_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkPollResponses.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/user/ur9812471/?ref_=login#pollResponses");

        }

        private void lnkAmphibia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkAmphibia.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/title/tt8050740/?ref_=nv_sr_srsg_0");

        }

        private void lnkInfinityTrain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkInfinityTrain.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/title/tt8146754/?ref_=nv_sr_srsg_0");

        }

        private void lnkUsualSuspects_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkUsualSuspects.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/title/tt0114814/?ref_=nv_sr_srsg_0");        
        }

        private void lnkGreenMile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkGreenMile.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/title/tt0120689/?ref_=nv_sr_srsg_0");

        }

        private void lnkCuckoo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkCuckoo.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/title/tt0073486/?ref_=nv_sr_srsg_0");
        }

        private void lnkConstantine_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkConstantine.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/title/tt0360486/?ref_=nv_sr_srsg_0");

        }

        private void lnkRegularShow_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkRegularShow.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/title/tt1710308/?ref_=fn_al_tt_1");
        }

        private void lnkRickMorty_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkRickMorty.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/title/tt2861424/?ref_=nv_sr_srsg_0");

        }

        private void lnkSchindlersList_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkSchindlersList.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/title/tt0108052/?ref_=nv_sr_srsg_0");
        }

        private void lnkSpiritedAway_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkSpiritedAway.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/title/tt0245429/?ref_=nv_sr_srsg_0");

        }

        private void lnkVForVendetta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lnkVForVendetta.LinkVisited = true;

            System.Diagnostics.Process.Start("https://www.imdb.com/title/tt0434409/?ref_=nv_sr_srsg_0");

        }
    }
}
