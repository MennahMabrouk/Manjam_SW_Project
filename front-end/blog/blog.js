// // Function to create the "Opportunity" table in local storage

// function createOpportunityTable() {
//   // Define the table structure as an object
//   const opportunityTable = {
//     title: null,
//     details: null,
//     link: null,
//   };

//   // Convert the object to a string and store it in local storage
//   localStorage.setItem("Opportunity", JSON.stringify(opportunityTable));
// }

// // Call the function to create the table
// createOpportunityTable();

// //////////////////////////////////////////////////////////////////////////////////////////////
// // Function to insert a new opportunity into the table
// function insertOpportunity(title, details, link) {
//   // Retrieve the existing table from local storage
//   let opportunityTable = JSON.parse(localStorage.getItem("Opportunity"));

//   // Create a new opportunity object
//   let newOpportunity = {
//     title: title,
//     details: details,
//     link: link,
//   };

//   // Insert the new opportunity into the table
//   opportunityTable.insertOpportunity(newOpportunity);
//   //   opportunityTable.push(newOpportunity);

//   // Update the table in local storage
//   localStorage.setItem("Opportunity", JSON.stringify(opportunityTable));
// }

// // Insert some example data into the table
// insertOpportunity(
//   "University of Melbourne",
//   "Partially Funded Scholarship",
//   "#link"
// );
// insertOpportunity(
//   "Harvard University",
//   "Full Scholarship for Computer Science",
//   "#link"
// );
// insertOpportunity(
//   "Stanford University",
//   "Partially Funded Scholarship for Business",
//   "#link"
// );

// /////////////////////////////////////////////////////////////////
// // Function to display the opportunities in HTML
// function displayOpportunities() {
//   // Retrieve the existing table from local storage
//   let opportunityTable = JSON.parse(localStorage.getItem("Opportunity"));

//   // Get the div element where the opportunities will be displayed
//   let opportunitiesDiv = document.getElementById("opportunities");

//   // Clear the div element before displaying new opportunities
//   opportunitiesDiv.innerHTML = "";

//   // Iterate through the opportunities and add them to the HTML
//   for (let i = 0; i < opportunityTable.length; i++) {
//     let opportunity = opportunityTable[i];
//     let html = `
//         <div class="opportunity">
//           <h3>${opportunity.title}</h3>
//           <p>${opportunity.details}</p>
//           <a href="${opportunity.link}" target="_blank">Learn More</a>
//         </div>
//       `;
//     opportunitiesDiv.innerHTML += html;
//   }
// }

// // Display the opportunities when the page loads
// displayOpportunities();

// /////////////////////////////////////////////////////////////////////////////////////////////
// Saving data as key/value pair
localStorage.setItem("name", "GeeksforGeeks");
localStorage.setItem("color", "green");

// Updating data
localStorage.setItem("name", "GeeksforGeeks(GfG)");
localStorage.setItem("color", "Blue");

// Get the data by key
let name = localStorage.getItem("name");
console.log("This is - ", name);
let color = localStorage.getItem("color");
console.log("Value of color is - ", color);

// Get key on a given position
let key1 = localStorage.key(1);
console.log(key1);

// Get number of stored items
let items = localStorage.length;
console.log("Total number of items is ", items);

// Remove key with its value
localStorage.removeItem("color");

// Delete everything
localStorage.clear();