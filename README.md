<!-- # Fundingstartup
webapp to collect funding for startups

# Crowdfundr

## Overview
Crowdfundr is a crowdfunding platform where startuppers can present their projects to be funded by financiers. The platform allows financiers to contribute funds, earn badges or stickers for their activity, and receive perks based on their contribution level.

## Features
- **Admin Role**: Manages users, projects, and badges. Oversees project completion and platform fees.
- **Startupper Role**: Can create projects, manage their progress, and start new fundraising campaigns. Projects move to a "Completed Projects" section once the goal is reached.
- **Financier Role**: Can fund projects, receive perks, and earn activity badges/stickers. They contribute to a platform fee (1%) during new fundraising campaigns based on their investment.
- **Badge/Stickers System**: Rewards the most active financiers with badges or stickers.
- **Completed Projects Section**: Displays projects that have met their funding goals.

## Technologies Used
- **Frontend**: ASP.NET Core MVC, Razor Pages
- **Backend**: C#, Entity Framework
- **Database**: SQL Server or SQLite
- **Authentication**: Identity Framework (roles: Admin, Startupper, Financier)

## Setup
1. Clone the repository.
2. Run `dotnet restore` to install dependencies.
3. Configure the database connection in `appsettings.json`.
4. Run the project using `dotnet run`.

## How to Use
1. **Register** as a startupper or financier.
2. **Startuppers** can create projects, manage them, and launch fundraising campaigns.
3. **Financiers** can browse and fund projects. Earn badges based on your activity and perks based on contribution levels.
4. **Admins** can manage users, projects, and the platform’s 1% fee.

## Database Schema
- **Users**: Stores user information and links to Identity Framework.
- **Projects**: Stores project details and goals.
- **Contributions**: Tracks the amount invested by each financier.
- **Perks**: Defines the perks for each contribution level.
- **Badges**: Tracks badges/stickers earned by financiers.
- **CompletedProjects**: Stores completed project data.
- **PlatformFees**: Tracks 1% platform fees and each financier’s contribution.

## Future Improvements
- Add payment gateway integration (e.g., Stripe, PayPal).
- Implement real-time notifications for project updates and funding milestones.
- Add social sharing features for projects.
-->

# **Crowdfundr - Crowdfunding Platform**

## **Project Overview**

Crowdfundr is a crowdfunding platform built with ASP.NET Core MVC, Entity Framework, and Identity Framework. The platform allows users to create, fund, and manage projects with role-based access control. The three user roles are:
- **Admin**: Manages users, projects, and finances.
- **Startupper**: Can create and manage their projects.
- **Financier**: Can browse and fund projects. Based on their contributions, they receive perks and badges.

The site charges a 1% fee on all new fundraising campaigns, which is distributed among the investors based on their contributions.

---

## **Key Features**
- **User Roles**:
  - **Admin**: Manages all users, approves projects, and oversees platform fees.
  - **Startupper**: Creates projects, defines funding goals, and manages perks for financiers.
  - **Financier**: Contributes to projects, receives perks, and earns badges based on activity.

- **Perks and Badges**:
  - **Perks**: Reward financiers based on their contributions to a project.
  - **Badges**: Earned by the most active financiers for their participation and contributions.

- **Completed Projects**: Projects that reach their funding goal are moved to the "Completed Projects" section.
  
- **Platform Fee**: A 1% platform fee is applied to all new fundraising campaigns.

---

## **Technologies Used**
- **Backend**: ASP.NET Core MVC, C#, Entity Framework Core
- **Frontend**: Razor Pages, HTML5, CSS3, Bootstrap
- **Database**: SQL Server or SQLite (configurable)
- **Authentication**: Identity Framework for user authentication and role management

---

## **Database Schema**

### **1. User Table**

| Column Name  | Data Type | Description                         |
|--------------|-----------|-------------------------------------|
| UserId       | string    | Primary key                         |
| FullName     | string    | Full name of the user               |
| Email        | string    | User's email                        |
| Role         | string    | User's role (Admin, Startupper, Financier) |

- **Relationships**:
  - One-to-many with **Contributions**
  - One-to-many with **Badges**
  - One-to-many with **Projects** (as Startupper)

---

### **2. Project Table**

| Column Name   | Data Type  | Description                         |
|---------------|------------|-------------------------------------|
| ProjectId     | int        | Primary key                         |
| Title         | string     | Title of the project                |
| Description   | string     | Detailed description of the project |
| GoalAmount    | decimal    | Total amount required               |
| CurrentAmount | decimal    | Amount raised so far                |
| CreatedAt     | DateTime   | Date of project creation            |
| IsCompleted   | bool       | Status of the project               |
| StartupperId  | string     | Foreign key referencing **User**    |

- **Relationships**:
  - One-to-many with **Contributions**
  - One-to-many with **Perks**

---

### **3. Contribution Table**

| Column Name    | Data Type  | Description                         |
|----------------|------------|-------------------------------------|
| ContributionId | int        | Primary key                         |
| Amount         | decimal    | Amount contributed                  |
| ContributedAt  | DateTime   | Date of contribution                |
| FinancierId    | string     | Foreign key referencing **User**    |
| ProjectId      | int        | Foreign key referencing **Project** |

- **Relationships**:
  - Many-to-one with **User** (Financier)
  - Many-to-one with **Project**

---

### **4. Perk Table**

| Column Name          | Data Type  | Description                                  |
|----------------------|------------|----------------------------------------------|
| PerkId               | int        | Primary key                                  |
| Description          | string     | Perk details                                 |
| MinimumContribution  | decimal    | Minimum contribution to earn the perk        |
| ProjectId            | int        | Foreign key referencing **Project**          |

- **Relationships**:
  - Many-to-one with **Project**

---

### **5. Badge Table**

| Column Name  | Data Type  | Description                        |
|--------------|------------|------------------------------------|
| BadgeId      | int        | Primary key                        |
| Name         | string     | Badge title                        |
| Description  | string     | Badge description                  |
| AwardedAt    | DateTime   | Date badge was awarded             |
| UserId       | string     | Foreign key referencing **User**   |

- **Relationships**:
  - Many-to-one with **User**

---

### **6. CompletedProject Table**

| Column Name         | Data Type  | Description                        |
|---------------------|------------|------------------------------------|
| CompletedProjectId   | int        | Primary key                        |
| CompletionDate       | DateTime   | Date of project completion         |
| TotalAmountRaised    | decimal    | Total funds raised                 |
| ProjectId            | int        | Foreign key referencing **Project**|

- **Relationships**:
  - One-to-one with **Project**

---

### **7. PlatformFee Table**

| Column Name  | Data Type  | Description                        |
|--------------|------------|------------------------------------|
| PlatformFeeId| int        | Primary key                        |
| TotalFee     | decimal    | Total 1% fee charged               |
| FeeDate      | DateTime   | Date of fee charge                 |
| ProjectId    | int        | Foreign key referencing **Project**|
| FinancierId  | string     | Foreign key referencing **User**   |

- **Relationships**:
  - Many-to-one with **Project**
  - Many-to-one with **User** (Financier)

---

## **Setup Instructions**

### **1. Prerequisites**
- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or [SQLite](https://www.sqlite.org/download.html)
- [Visual Studio](https://visualstudio.microsoft.com/) or [VS Code](https://code.visualstudio.com/)

### **2. Clone the Repository**
```bash
git clone https://github.com/yourusername/crowdfundr.git
cd crowdfundr
