# 🗂️ Generic Repository Pattern in C#

This repository demonstrates the **Generic Repository Pattern** using **Entity Framework Core** in C#.  
It provides a reusable and maintainable data access layer for any entity class.

---

## 🚀 Overview

The repository includes:

- **IRepository\<T>** – Interface defining generic CRUD operations.  
- **Repository\<T>** – Generic class implementing the repository pattern.

This approach helps keep your data access logic **clean**, **reusable**, and **separated from business logic**.

---

## 📄 Interface Definition

```csharp
public interface IRepository<T> where T : class
{
    IEnumerable<T> GetAll();
    T? GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(T entity);
    void Save();
}
