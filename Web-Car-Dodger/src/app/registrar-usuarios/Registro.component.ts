import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { registro } from './Registro';
import { RegistroService } from './Registro.service';

@Component({
  selector: 'app-registrar-usuarios',
  templateUrl: './Registro.component.html',
  styleUrls: ['./Registro.component.css']
})
export class RegistroComponent implements OnInit {

  public registros: registro = new registro();
  
  constructor(private registroService: RegistroService,
  private router: Router){}

  ngOnInit(): void {
  }

  public createUsuario(): void{

    this.registroService.createUsuario(this.registros).subscribe(
      response => this.router.navigate(['/Registro'])
    )

    console.log("enviado")
    console.log(this.registros)
  }
}
