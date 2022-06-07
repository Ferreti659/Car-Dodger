import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { RouterModule, Routes } from '@angular/router';
import {HttpClientModule} from '@angular/common/http';
import { FormsModule } from '@angular/forms';


import { FooterComponent } from "./footer/footer.component";

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';
import { InicioSesionComponent } from './inicio-sesion/inicio-sesion.component';
import { ComentariosComponent } from './comentarios/comentarios.component';
import { RegistrarUsuariosComponent } from './registrar-usuarios/registrar-usuarios.component';
import { BodyComponent } from './body/body.component';



const routes: Routes = [

  {path: '', redirectTo: '/', pathMatch: 'full'},
  {path: 'InicioSesion', component: InicioSesionComponent},
  {path: 'Comentarios', component: ComentariosComponent},
  {path: 'RegistrarUsuarios', component: RegistrarUsuariosComponent},
  {path: 'BodyComponent', component: BodyComponent},


];


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    InicioSesionComponent,
    ComentariosComponent,
    RegistrarUsuariosComponent,
    BodyComponent,
    FooterComponent

  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(routes)
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
