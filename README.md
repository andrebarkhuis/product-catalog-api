Technical Assessment 
---

Objective Evaluate comprehensive technical expertise in software development, Kubernetes, and cloud-native monitoring/logging.

### **Part 1: Code Review & Architectural Design**

- Refactor the ProductController so that it only handles HTTP requests and delegates business logic, data access, and other responsibilities to separate classes.
- Design and implement a feature that allows for adding discount rules to products without modifying existing code in the ProductController.
- Ensure that the ProductController can handle both a base class called Product and a derived class called DigitalProduct without knowing the difference between them.
- Define clear interfaces for the various operations that can be performed on a product. Ensure that classes implementing these interfaces aren't forced to implement methods they don't use.
- Refactor the ProductController and associated classes to depend upon abstractions (e.g., interfaces) rather than concretions (e.g., direct instantiation).
- Review the ProductController for any code smells, unnecessary redundancies, or unclear naming conventions. Refactor the code to improve its readability and maintainability.
---

### **Part 2: Coding Task**

**1. Database Interaction**  
   - Design a database schema for the `Product` entity.
   - Implement ORM integration (e.g., Entity Framework) to connect the API to the database.
   - Use the default InMemory DB for entity framework

**2. Unit Testing**  
   - Write unit tests for the CRUD operations and the domain events.
   - Ensure the test coverage is above 80%.
---

### **Part 3: Cloud-native Monitoring and Logging**

**1. Monitoring Task**  
   - Recommend and justify a monitoring solution for cloud-native applications.
   - Set up alerting thresholds and incident response for critical issues.

**2. Logging Task**  
   - Propose a centralized logging solution for microservices in a cloud-native setting.
   - Describe the integration of application logs with the chosen logging solution.
   - Discuss strategies for log retention, search, and analysis in cloud-native contexts.
---

### **Part 4: Kubernetes Assessment**

**1. Kubernetes Task**  
   - Detail steps to containerize the developed .NET Core API using Docker.
   - Create Kubernetes deployment and service YAML manifest for the API, using ConfigMaps and Secrets for configurations and sensitive data.
   - Discuss strategies for application updates and rollbacks in Kubernetes.
   - Explain ensuring high availability of the application in a Kubernetes cluster.

**2. Kubernetes Architecture**  
   - Explain the role and benefits of Helm in Kubernetes.
   - Discuss workload segregation in a multi-team Kubernetes environment using namespaces and other techniques.
   - Elaborate on a monitoring and logging strategy in a Kubernetes environment.
---
