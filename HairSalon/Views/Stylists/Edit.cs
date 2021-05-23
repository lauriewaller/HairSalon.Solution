// @{
//   Layout = "_Layout";
// }

// @using HairSalon.Models;

// <h1>Stylists</h1>

// @if (@Model.Count == 0)
// {
//   <h3>No stylists have been added yet!</h3>
// } 

// <ul>
//   @foreach(Stylist stylist in Model)
//   {
//     <li>@Html.ActionLink($"{stylist.Name}", "Details", new { id = stylist.StylistId })</li>
//   }
// </ul>

// <p>@Html.ActionLink("Add new stylist", "Create")</p>
// <p>@Html.ActionLink("Home", "Index", "Home")</p>


// @{
//   Layout = "_Layout";
// }

// @using HairSalon.Models;
// @model List<HairSalon.Models.Client>;


// <h1>Clients</h1>

// <ul>
//   @foreach(Client client in Model)
//   {
//     <li>@client.Name</li>
//   }
// </ul>