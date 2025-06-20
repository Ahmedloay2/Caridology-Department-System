
<h1 align="center">
  <br>
  <a href="https://cardio-w-tever.vercel.app/index.html"><img src="https://github.com/alhussien-ayman/cardio_WTever/blob/main/assets/img/Logotest.png" alt="Cardiology WTever" width="200"></a>
  <br>
  Cardiology WTever
  <br>
</h1>


# 🫀Cardiology Hospital Information System 
Welcome to the Cardiology Hospital Information System (HIS) – your gateway to modern, efficient, and patient-centered heart care management.


---

### 🚀 **Live Demo**

👉 [Explore the Live System](https://cardio-w-tever.vercel.app/)

### 🗂️ **Project Repository**

📁 [View the GitHub Repository](https://github.com/Ahmedloay2/Caridology-Department-System)

---


  
### 🔸 ER Model  
<img src="schemas/ER diagram.png" alt="ER Diagram" width="700"/>

---

### 🔸 Relational Schema  
<img src="schemas/Relational.png" alt="Relational Model" width="700"/>

## 📌 Project Overview
This web application serves as a **Cardiology Department Information System**, aiming to enhance healthcare operations through digital transformation. In **Phase 1**, we focused on building the foundational features, including authentication, registration, and patient profile management with a responsive user interface.

---


## ✅  Implemented Features

### 🔹1. User Interface Pages
- **Homepage**: Welcoming interface with department overview and navigation options
- **Login Page**:Role-based secure login for patients, doctors, and admins 
- **Registration Page**: Multi-step form for new patient accounts
- **Profile Page**: Detailed view of patient information with edit capabilities

### 🔹2. Core Functionalities
- **User Authentication System**
  - Role-based login (Patient/Doctor/Admin)
  - Secure password handling
- **Patient Profile Management**
  - Personal information section
  - Medical history tracking
  - Contact details management
  - Family and emergency contact information
- **Responsive Design**
  - Mobile-friendly layouts
  - Consistent styling across pages

---
## 💻 Technical Implementation

### Frontend
- HTML5/CSS3 for page structure and styling
- Bootstrap framework for responsive design
- JavaScript for interactive elements
- Form validation for data integrity

### Backend 
- Custom **ER model** and **Relational Schema** tailored to cardiology data requirements 
- User authentication system planned
- API endpoints outlined for future development
---

## 🖼️ Our Web  

### 🔸 Homepage  
<img src="readme images/Home page.png " alt="Homepage" width="700"/>

---

### 🔸 Login Page  
<img src="readme images/Login page.png" alt="Login Page" width="700"/>

---

### 🔸 Registration Process  
**Step 1 – Personal Information**  
<img src="readme images/register-01.png" alt="Registration Step 1" width="700"/>

**Step 2 – Account Information**  
<img src="readme images/register-02.png" alt="Registration Step 2" width="700"/>

**Step 3 – Contact Information**  
<img src="readme images/register-03.png" alt="Registration Step 3" width="700"/>

---

### 🔸 Patient Profile  
<img src="readme images/Profile page.png" alt="Patient Profile" width="700"/>


---

## 🔜 Next Steps – Phase 2 Plan  
- Develop doctor profiles and dashboards
- Create appointment scheduling system
- Add medical record management
- Implement admin dashboard

---
## API Endpoints

| HTTP Method | URL                             | Action                                  |
|-------------|---------------------------------|-----------------------------------------|
| GET         | `/api/Patient/Profile`          | Get logged-in patient info              |
| PUT         | `/api/Patient/UpdateProfile`    | Update logged-in patient                |
| POST        | `/api/Patient/register`         | Register new patient                    |
| POST        | `/api/Patient/Login`            | Login patient                           |
| POST        | `/api/Patient/Logout`           | Logout patient                          |
| Delete      | `/api/Patient/Delete`           | Delete patient                          |
| GET         | `/api/Admin/Profile`            | Get logged-in Admin info                |
| PUT         | `/api/Admin/Profile`            | Update logged-in Admin                  |
| POST        | `/api/Admin/CreateAdmin`        | Create new Admin                        |
| POST        | `/api/Admin/Login`              | Login Admin                             |
| POST        | `/api/Admin/Logout`             | Logout Admin                            |
| Delete      | `/api/Admin/Delete`             | Delete Admin                            |
| GET         | `/api/Doctor/Profile`           | Get logged-in Doctor info               |
| PUT         | `/api/Doctor/UpdateProfile`     | Update logged-in Doctor                 |
| POST        | `/api/Doctor/CreateDoctor`      | Create new Doctor                       |
| POST        | `/api/Doctor/Login`             | Login Doctor                            |
| POST        | `/api/Doctor/Logout`            | Logout Doctor                           |
| Delete      | `/api/Doctor/Delete`            | Delete Doctor                           |
| Get         | `/api/Doctor/DoctorsProfileList'| Get List of Doctors Profiles            |
| Get         | `/api/Doctor/DoctorsList`       | Get List of Doctors                     |
| Get         | `/api/Message/GetMessage`       | Get Messages between Patient and Doctor |
| Post        | `/api/Message/SendMessage`      | Send Mesaage to Patient or Doctor       |
---
## Backend
- Developed a cardiology department website using .NET for backend logic.

- Implemented an API to handle communication between system components and external services.

- Used JWT (JSON Web Tokens) for secure user authentication and API access.

- Stored and managed data using Neon PostgreSQL, a cloud-native, scalable database solution.
---

### 👥 Team Members

| Name                        |
|-----------------------------|
| Alhussien Ayman Hanafy      |
| Ahmed Loay Elsayyed         |
| Suhila Tharwat Elmasry      |
| Mai Mahmoud Mohamed         |
| Muhammad Khaled Abdalhameed |



