const sql = require("msnodesqlv8");
const express = require("express");
const bodyparse = require("body-parser");

const app = express();
app.use(express.static("public"));
app.use(bodyparse.urlencoded({ extended: true }));

app.set("views", "./views");
app.set("view engine", "ejs");
const connectionstring =
  "server=DESKTOP-P3PTCL8\\SQLEXPRESS;Database=PremierServiceSolutions;Trusted_Connection=Yes;Driver={SQL Server Native Client 11.0}";

app.get("/", function (req, res) {
  res.sendFile(__dirname + "/index.html");
});
app.get("/register", (req, res) => {
  res.sendFile(__dirname + "/Website Pages/portal.html");
});
app.get("/business", (req, res) => {
  res.sendFile(__dirname + "/Website Pages/portal copy.html");
});
app.post("/add", (req, res) => {
  let query = `insert into dbo.customer(Name,Surname,PackagesID,PhoneNumber,Email,DOB,Street,zip,city) values('${req.body.firstname}','${req.body.lastName}',${req.body.packagesID},'${req.body.phone}','${req.body.email}',' ','${req.body.address}','${req.body.zip}','City')`;
  sql.query(connectionstring, query, function (err, rows) {
    if (err) {
      console.error("Error executing query:", err);
      return res.status(500).send("An error occurred while fetching data.");
    }

    // res.json(rows);
  });
});
//
let id;
{
  // Name, Surname, PackagesID, PhoneNumber, Email, DOB, Street, zip, city;
  app.post("/addbusinesS", function (req, res) {
    let query = `insert into dbo.customer(Name,Surname,PackagesID,PhoneNumber,Email,DOB,Street,zip,city) values('Business','${req.body.lastName}',${req.body.packagesID},'','','','${req.body.address}','${req.body.zip}','City') select Top 1 customerID from Customer order by CustomerID desc`;
    sql.query(connectionstring, query, function (err, rows) {
      if (err) {
        console.error("Error executing query:", err);
        return res.status(500).send("An error occurred while fetching data.");
      }
      id = rows[0];
      // res.json(rows);
    });
  });
  let bid;
  app.post("/addBusinessRole", function (req, res) {
    let query = `insert into BusinessRole(Name,Surname,ContactNumber,BusinessRole) values('${req.body.name}','${req.body.surname}','${req.body.phone}','${req.body.role}');select Top 1 BusinessRoleID from BusinessRole order by BusinessRoleID desc`;
    sql.query(connectionstring, query, function (err, rows) {
      if (err) {
        console.error("Error executing query:", err);
        return res.status(500).send("An error occurred while fetching data.");
      }
      bid = rows[0];
      // busiesscutomer();
    });

    // function busiesscutomer() {
    //   let query = `insert into BusinessCustomer(CustomerID,BusinessRoleID) values(${Id},${bid});`;
    //   sql.query(connectionstring, query, function (err, rows) {
    //     if (err) {
    //       console.error("Error executing query:", err);
    //       return res.status(500).send("An error occurred while fetching data.");
    //     }
    //   });
    // }
    app.post("/businessCustomer", (req, res) => {
      // res.json(rows);
    });
  });
  let server = app.listen(8080, function () {
    console.log("http://localhost:8080");
  });
}
