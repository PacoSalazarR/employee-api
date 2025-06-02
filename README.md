---
## POST /api/employees

{
  "id": 1,
  "name": "Francisco",
  "lastName": "Salazar",
  "rfc": "ABCD123456FS2",
  "bornDate": "2001-03-18",
  "status": "Active"
}


## GET /api/employees?name=francisco
---
(returns all employees filteres by name, sorted by birth date)
