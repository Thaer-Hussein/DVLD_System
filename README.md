#  DVLD - Driving License Management System

A full desktop-based system designed to manage driving license services, applications, and users within a Driving & Vehicle License Department (DVLD).

This system simulates a real-world government workflow for issuing and managing driving licenses with multiple services and validations.

---

##  Project Overview

DVLD is a complete management system that handles:

* Driving license issuance (first-time)
* License renewal
* Replacement for lost or damaged licenses
* International license issuance
* Test management (vision, theory, practical)
* Applications processing and tracking
* User and people management

The system enforces real-world business rules and workflows to ensure data integrity and process correctness.

---

##  Tech Stack

* **Windows Forms (.NET)** – Desktop UI
* **ADO.NET** – Data access layer
* **Microsoft SQL Server** – Database
* **Waterfall Methodology** – Development approach

---

##  System Architecture

The solution follows a layered architecture:

```
DVLD/
├── DVLD_System        → Presentation Layer (UI)
├── DC (DVLD_Business)     → Business Logic Layer
├── DVLD_DataAccess    → Data Access Layer
```

* **Presentation Layer**: Handles user interaction
* **Business Layer**: Contains validation and core logic
* **Data Access Layer**: Handles communication with SQL Server

---

##  Core Features

###  License Services

* Issue new driving license
* Renew driving license
* Replace lost license
* Replace damaged license
* Issue international license
* Release detained licenses

###  Test Management

Applicants must pass the following tests in order:

1. Vision Test
2. Theory Test
3. Practical Driving Test

* Each test requires scheduling and payment
* Failed tests can be retaken with a new appointment

---

###  Applications System

* Each service requires an application
* Applications include:

  * Applicant info
  * Service type
  * Status (New, Cancelled, Completed)
  * Paid fees
* Prevents duplicate or invalid applications

---

###  People & Users Management

* Store and manage personal data:

  * National ID
  * Full name
  * Date of birth
  * Contact information
* Manage system users:

  * Add / update / delete users
  * Assign permissions
  * Enable/disable accounts

---

###  Business Rules Enforcement

The system ensures:

* Minimum age requirements per license class
* No duplicate licenses for the same category
* No multiple active applications of the same type
* Sequential test completion (Vision → Theory → Practical)
* License eligibility validation before issuance

---

##  Database

The system uses **SQL Server**.

Database scripts are included in the `Database/` folder.

### Setup Steps:

1. Open SQL Server Management Studio (SSMS)
2. Run the SQL script provided
3. Update the connection string in the project
4. Run the application

---

##  How to Run

1. Clone the repository:

```
git clone https://github.com/YOUR_USERNAME/DVLD_System.git
```

2. Open the solution file:

```
DVLD.sln
```

3. Set `DVLD_System` as Startup Project

4. Make sure SQL Server is running and configured

5. Run the project

---

##  Notes

* This project is built for learning and demonstration purposes
* It simulates real-world workflows in a government licensing system
* Focuses on business logic, data integrity, and system structure

---

##  Author

Developed by: **Thaer Hussein**

---

##  If you found this project useful

Feel free to star the repository and share your feedback!

