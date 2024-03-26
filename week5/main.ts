
interface User {
  name: string;
  age: number;
  getName: () => string;
}

interface Admin extends User {
  role: string;
}


const user: User = {
  name: 'John',
  age: 30,
  getName() {
    return this.name;
  }
};


const admin: Admin = {
  name: 'Jane',
  age: 30,
  role: 'Admin',
  getName() {
    return this.name;
  }
};

// union of User and Admin
let userOrAdmin: User | Admin = user;

userOrAdmin = admin;
