﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StoreInSessionObject
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                lblUsername.Text = Session["username"].ToString();
            }
            else
            {
                lblUsername.Text = "Seems that you're not logged in. Please login first";
            }
        }
    }
}