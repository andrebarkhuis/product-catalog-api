Technical Assessment 
---

Objective Evaluate comprehensive technical expertise in software development, Kubernetes, and cloud-native monitoring/logging.

### **Part 1: Coding Task**

**1. RESTful API with Domain Events**  
   - Develop a RESTful API using .NET Core for a `Product` entity with CRUD operations.  
   - For each CRUD operation, raise a corresponding domain event (e.g., `ProductCreatedEvent`, `ProductUpdatedEvent`, etc.).
   - Implement a middleware to log each request-response cycle in the system.

**2. Database Interaction**  
   - Design a database schema for the `Product` entity.
   - Implement ORM integration (e.g., Entity Framework) to connect the API to the database.
   - Implement a migration script to initialize the database.

**3. Unit Testing**  
   - Write unit tests for the CRUD operations and the domain events.
   - Ensure the test coverage is above 80%.

**4. Asynchronous Processing**  
   - Implement asynchronous processing where domain events are pushed to a queue (e.g., RabbitMQ or an in-memory queue) and processed by a background worker.

---

### **Part 2: Kubernetes Assessment**

**5. Kubernetes Task**  
   - Detail steps to containerize the developed .NET Core API using Docker.
   - Create Kubernetes deployment and service YAML manifest for the API, using ConfigMaps and Secrets for configurations and sensitive data.
   - Discuss strategies for application updates and rollbacks in Kubernetes.
   - Explain ensuring high availability of the application in a Kubernetes cluster.

**6. Kubernetes Architecture**  
   - Explain the role and benefits of Helm in Kubernetes.
   - Discuss workload segregation in a multi-team Kubernetes environment using namespaces and other techniques.
   - Elaborate on a monitoring and logging strategy in a Kubernetes environment.

---

### **Part 3: Cloud-native Monitoring and Logging**

**7. Monitoring Task**  
   - Recommend and justify a monitoring solution for cloud-native applications.
   - Set up alerting thresholds and incident response for critical issues.

**8. Logging Task**  
   - Propose a centralized logging solution for microservices in a cloud-native setting.
   - Describe integration of application logs with the chosen logging solution.
   - Discuss strategies for log retention, search, and analysis in cloud-native contexts.

---

### **Part 4: Code Review & Architectural Design**

**9. Code Review Task & Architectural Design**  
   - *Provide the same details as mentioned earlier.*

**10. Problem Solving & Algorithmic Challenge**  
   - *Provide the same details as mentioned earlier.*

---

### **Submission Instructions**

Push all tasks, configurations, and related documents to your GitHub repository. Ensure that architectural diagrams, Kubernetes configurations, etc., are included as markdown files or are hosted within separate folders or document files in the repository.

---

I hope this format makes it easy for you to utilize on GitHub or any other platform!
