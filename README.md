# .NET Core Project with Onion Architecture

## Overview
This repository contains a robust and scalable .NET Core application that utilizes the **Onion Architecture** for maintainability and separation of concerns. By adhering to best practices and design principles, this project sets the groundwork for building enterprise-level applications.

## Key Features
- **Onion Architecture**: Ensures that the application's corethis project sets the groundwork for building enterprise-level applications business logic remains at the center and free of dependencies, providing a maintainable and decoupled design.
- **Repository Design Pattern**: Helps in abstracting the data layer, making the application more flexible to changes in the data source.
- **CQRS (Command Query Responsibility Segregation)**: This design pattern is used to separate the read and write operations, allowing for scalability and maintainability.
- **Docker with PostgreSQL**: Our database layer is PostgreSQL which has been containerized using Docker for easy setup, distribution, and scalability.
- **Angular for Presentation Layer**: The user interface is built using Angular, a popular front-end framework, ensuring a responsive and dynamic user experience.
