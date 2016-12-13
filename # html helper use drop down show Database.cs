1)Controller Code
--------------------
public List<SelectListItem> GetCountry()
        {
            List<Country> aCountry = aCountryManager.GetCountry();
            List<SelectListItem> aSelectListItems = new List<SelectListItem>();
            aSelectListItems.Add(new SelectListItem(){Value = "",Text = "Please Select"});
            foreach (var c in aCountry)
            {
                SelectListItem i = new SelectListItem();
                i.Text = c.Name.ToString();
                i.Value = c.Id.ToString();
                aSelectListItems.Add(i);
            }
            return aSelectListItems;
        }
2) <div class="form-group">
            @Html.LabelFor(model => model.CountryId, new { @class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownList("Country", new SelectList(ViewBag.GetCountry, "Value", "Text"))
                @Html.ValidationMessageFor(model => model.CountryId)
            </div>
        </div>
