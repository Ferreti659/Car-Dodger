import { Component } from "@angular/core";
import { UsersService } from "../users/users.service";

@Component({
  selector: "app-register",
  templateUrl: "./register.component.html",
  styleUrls: ["./register.component.css"]
})
export class RegisterComponent {
  email!: string;
  password!: string;
  confirmPassword: string | undefined;
  passwordError!: boolean;

  constructor(public userService: UsersService) {}

  register() {
    const user = { email: this.email, password: this.password };
    this.userService.register(user).subscribe((data: { token: String; }) => {
      this.userService.setToken(data.token);
    });
  }
}
