# .NET Core Project with Onion Architecture (In Progress)

## Overview
This repository is dedicated to a .NET Core application currently under development. We're leveraging the **Onion Architecture** to ensure maintainability and a clear separation of concerns. The aim is to create a robust and scalable application by integrating best practices and efficient design patterns.

## Key Features (Planned & In-Progress)
- **Onion Architecture**: A structure where the Domain, or the core business logic, remains at the center, ensuring it remains isolated and free from external dependencies. This approach aims to create a maintainable, decoupled, and cohesive design.
- **Repository Design Pattern**: This pattern will be used to abstract the data layer, intending to make the application adaptable to potential changes in the data source.
- **CQRS (Command Query Responsibility Segregation)**: Planning to implement this design pattern to segregate read and write operations, which could aid in scalability and maintainability.
- **Docker with PostgreSQL**: We're setting up our database layer with PostgreSQL and plan to containerize it using Docker for ease of setup and scalability.
- **Angular for Presentation Layer**: The user interface is planned to be built using Angular to provide a dynamic user experience.
