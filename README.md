# Airport Passenger Tracking & Assistance System

A full-stack web application built with **ASP.NET Core MVC** and **Entity Framework Core**, designed to streamline the tracking and operational management of Passengers with Reduced Mobility (PRM) across airport terminals in real time.

---

## 📌 Overview & Problem Statement
In airport ground operations, managing special assistance services (wheelchairs, stretchers, visual/mobility aid escorts) demands real-time data integrity and immediate status visibility. 

This platform eliminates traditional page reloads through asynchronous client-server communication, providing dispatchers and field staff with dynamic operational metrics, instant status transitions, and reliable local SQL persistence.

---

## 🚀 Key Features
* **Full CRUD Lifecycle:** Seamless creation, retrieval, updating, and deletion of passenger service records.
* **Asynchronous Client-Server Flow (Fetch API):** Non-blocking background communication with ASP.NET Core endpoints for real-time DOM manipulation.
* **Live Operational Counters:** Dynamic metric cards (Total, Pending, Completed) that update synchronously with every user interaction without refreshing the page.
* **Instant Status Toggle:** One-click operation to switch passenger statuses between *Pending* and *Completed* via dedicated backend action methods.
* **Relational Persistence:** Robust data modeling powered by EF Core Code-First approach with database migrations.

---

## 🛠️ Tech Stack & Architecture
* **Backend:** C#, .NET 8 / ASP.NET Core MVC
* **ORM & Database:** Entity Framework Core, Microsoft SQL Server (LocalDB / Express)
* **Frontend:** Modern JavaScript (ES6+ Fetch API, DOM Manipulation), Bootstrap 5, Razor Views
* **Architectural Principles:** Dependency Injection (DI), MVC Pattern, Clean Code Standards

---

## ⚙️ Getting Started

### Prerequisites
* [.NET 8 SDK](https://dotnet.microsoft.com/download)
* SQL Server (LocalDB or SQL Server Express)
* Visual Studio 2022 / VS Code

### Installation & Run
1. Clone the repository:
   ```bash
   git clone [https://github.com/emirgokmen/PassengerTrackingApp.git](https://github.com/emirgokmen/PassengerTrackingApp.git)
   cd PassengerTrackingApp
