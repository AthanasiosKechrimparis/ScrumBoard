﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebScrum
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        List<Tasks> listoftasks;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            TransferList(lsBox1, lsbox2);
        }


        public void TransferList(ListBox from, ListBox To)
        {
            for (int i = 0; i < from.Items.Count; i++)
            {
                if (from.Items[i].Selected)
                {
                    To.Items.Add(from.SelectedItem);
                    from.Items.Remove(from.Items[i]);
                }
            }
            from.SelectedIndex = -1;
            To.SelectedIndex = -1;
        }
    }
}