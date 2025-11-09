# \# 🗂️ Generic Repository Pattern in C#

# 

# This repository demonstrates the \*\*Generic Repository Pattern\*\* using \*\*Entity Framework Core\*\* in C#.  

# It provides a reusable and maintainable data access layer for any entity class.

# 

# ---

# 

# \## 🚀 Overview

# 

# The repository includes:

# 

# \- \*\*IRepository\\<T>\*\* – Interface defining generic CRUD operations.

# \- \*\*Repository\\<T>\*\* – Generic class implementing the repository pattern.

# 

# This approach helps keep your data access logic clean, reusable, and separated from business logic.

# 

# ---

# 

# \## 📄 Interface Definition

# 

# ```csharp

# public interface IRepository<T> where T : class

# {

# &nbsp;   IEnumerable<T> GetAll();

# &nbsp;   T? GetById(int id);

# &nbsp;   void Add(T entity);

# &nbsp;   void Update(T entity);

# &nbsp;   void Delete(T entity);

# &nbsp;   void Save();

# }



