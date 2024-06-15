# PLANWISER README

## Table of Contents
- [Introduction](#introduction)
- [Features](#features)
- [Tech Stack](#tech-stack)
- [Prerequisites](#prerequisites)
- [Installation](#installation)
- [Configuration](#configuration)
- [Usage](#usage)
- [Contributing](#contributing)
- [License](#license)
- [Contact](#contact)

## Introduction
PLANWISER is a web application designed to help users generate a customized study plan based on their deadline, available study hours, personal capabilities, and syllabus details. The application leverages Azure OpenAI Service to optimize the study plan and ensures a balanced and efficient learning schedule. PLANWISER integrates with Azure Web App Service and Azure Active Directory for seamless deployment and secure user authentication. Developed using the .NET framework, PLANWISER provides a robust and scalable solution for personalized study planning.

## Features
- **Personalized Study Plan Generation**: Creates a study plan tailored to the user's input including deadline, available hours, and capabilities.
- **Azure OpenAI Integration**: Utilizes AI to optimize the study schedule.
- **Secure Authentication**: Uses Azure Active Directory for secure user login and access management.
- **Scalable Deployment**: Hosted on Azure Web App Service for high availability and scalability.

## Tech Stack
- **Backend**: .NET Framework
- **Frontend**: HTML, CSS, JavaScript
- **AI Service**: Azure OpenAI Service
- **Hosting and Deployment**: Azure Web App Service
- **Authentication**: Azure Active Directory

## Prerequisites
- **.NET SDK**: Ensure you have the .NET SDK installed on your machine.
- **Azure Account**: You need an Azure account to set up the required services.
- **Azure CLI**: Install Azure CLI for managing Azure resources.
- **IDE**: Use Visual Studio or any other preferred IDE for .NET development.

## Installation
1. **Clone the Repository**:
   ```sh
   git clone https://github.com/yourusername/planwiser.git
   cd planwiser
   ```

2. **Restore Dependencies**:
   ```sh
   dotnet restore
   ```

3. **Build the Application**:
   ```sh
   dotnet build
   ```

4. **Run the Application Locally**:
   ```sh
   dotnet run
   ```

## Configuration
1. **Azure OpenAI Service**: 
   - Set up your Azure OpenAI Service and obtain the API key.
   - Add the API key to the application configuration file (`appsettings.json`).

2. **Azure Active Directory**:
   - Register your application with Azure Active Directory.
   - Configure the authentication settings in `appsettings.json` with your Directory ID, Application ID, and Client Secret.

3. **Azure Web App Service**:
   - Deploy the application to Azure Web App Service.
   - Follow the Azure documentation for deploying .NET applications to Azure Web App Service.

## Usage
1. **Access the Application**: Once deployed, access the application through the provided Azure Web App URL.
2. **User Login**: Log in using your Azure Active Directory credentials.
3. **Input Details**: Enter your study plan details including deadline, available hours, personal capabilities, and syllabus.
4. **Generate Plan**: Click on the "Generate Plan" button to receive a personalized study plan.

## Contributing
We welcome contributions to enhance PLANWISER. To contribute:
1. Fork the repository.
2. Create a new branch.
3. Make your changes and commit them.
4. Push your changes to your fork.
5. Create a pull request.


## Contact
For questions, feedback, or support, please contact us at shouryya.v.monga@gmail.com.

Thank you for using PLANWISER! We hope it helps you achieve your study goals efficiently.
