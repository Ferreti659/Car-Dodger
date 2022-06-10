import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { RouterModule, Routes } from '@angular/router';
import {HttpClientModule} from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { CookieService } from 'ngx-cookie-service';


import { FooterComponent } from "./footer/footer.component";

import { AppComponent } from './app.component';
import { HeaderComponent } from './header/header.component';

import { ComentariosComponent } from './comentarios/comentarios.component';

import { BodyComponent } from './body/body.component';
import { DescargasComponent } from './descargas/descargas.component';
import { LoginComponent } from './login/login.component';
import { RegisterComponent } from './register/register.component';





const routes: Routes = [

  {path: '', redirectTo: '/', pathMatch: 'full'},
  {path: 'InicioSesion', component: LoginComponent},
  {path: 'Comentarios', component: ComentariosComponent},
  {path: 'RegistrarUsuarios', component: RegisterComponent},
  {path: 'BodyComponent', component: BodyComponent},
  {path: 'Descargas', component: DescargasComponent},


];


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    LoginComponent,
    ComentariosComponent,
    RegisterComponent,
    BodyComponent,
    FooterComponent,
    DescargasComponent,
    LoginComponent,



  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot(routes)
  ],
  providers: [CookieService],
  bootstrap: [AppComponent]
})
export class AppModule { }
