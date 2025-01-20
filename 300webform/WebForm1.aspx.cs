using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace webform
{
    public partial class WebForm1 : System.Web.UI.Page 
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Only load states if it's the first page load
            if (!IsPostBack)
            {
                LoadStates();
            }
        }

        // Load the initial list of states
        protected void LoadStates()
        {
            // Clear dependent dropdowns
             district.Items.Clear();
            municipality.Items.Clear();
            wardno.Items.Clear();

            // Populate the states dropdown
            List<ListItem> states = new List<ListItem>
            {
                new ListItem("Select a state", ""),
                new ListItem("Mechi", "Mechi"),
                new ListItem("Koshi", "Koshi"),
                new ListItem("Bagmati", "Bagmati"),
                new ListItem("Lumbini", "Lumbini"),
                new ListItem("Dhaulagiri", "Dhaulagiri"),
                new ListItem("Karnali", "Karnali"),
                new ListItem("Mahakali", "Mahakali")
            };

           state.Items.Clear();
           state.Items.AddRange(states.ToArray());
        }

        // Populate the district dropdown based on the selected state
        protected void LoadDistrictOnStateSelect(object sender, EventArgs e)
        {
            // Clear dependent dropdowns
            district.Items.Clear();
            municipality.Items.Clear();
            wardno.Items.Clear();

            district.Items.Add(new ListItem("Select a District", ""));

            List<ListItem> districts = new List<ListItem>();

            // Generate dummy districts for the selected state
            if (!string.IsNullOrEmpty(state.SelectedValue))
            {
                string SelectedState = state.SelectedValue;
                for (int i = 1; i <= 5; i++)
                {
                    string district = $"{SelectedState} District-{i}";
                    districts.Add(new ListItem(district, district));
                }
            }

            district.Items.AddRange(districts.ToArray());
        }
        /// <summary>
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        // Populate the municipality dropdown based on the selected district
        protected void LoadMunicipalityOnDistrictSelect(object sender, EventArgs e)
        {
            // Clear dependent dropdowns
            municipality.Items.Clear();
            wardno.Items.Clear();

            municipality.Items.Add(new ListItem("Select a Municipality", ""));

            List<ListItem> municipalities = new List<ListItem>();

            // Generate dummy municipalities for the selected district
            if (!string.IsNullOrEmpty(district.SelectedValue))
            {
                string SelectedDistrict = district.SelectedValue;
                for (int i = 1; i <= 5; i++)
                {
                    string municipality = $"{SelectedDistrict} Municipality-{i}";
                    municipalities.Add(new ListItem(municipality, municipality));
                }
            }

            municipality.Items.AddRange(municipalities.ToArray());
        }

        // Populate the ward number dropdown based on the selected municipality
        protected void LoadWardNoOnMunicipalitySelect(object sender, EventArgs e)
        {
            wardno.Items.Clear();

           wardno.Items.Add(new ListItem("Select a Ward", ""));

            List<ListItem> wards = new List<ListItem>();

            // Generate dummy wards for the selected municipality
            if (!string.IsNullOrEmpty(municipality.SelectedValue))
            {
            string SelectedMunicipality = municipality.SelectedValue;
                for (int i = 1; i <= 5; i++)
                {
                    string ward = $"{SelectedMunicipality} Ward-{i}";
                    wards.Add(new ListItem(ward, ward));
                }
            }

            wardno.Items.AddRange(wards.ToArray());
        }
    }
}
