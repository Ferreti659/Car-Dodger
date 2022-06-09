import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { registro } from './Registro';

@Injectable({
  providedIn: 'root'
})
export class RegistroService {


    
  private urlEndPoint: string = 'http://localhost:8080';

  private httpHeaders = new HttpHeaders({'Content-Type': 'application/json'})
  constructor(private http: HttpClient) { }


  createUsuario(registros: registro): Observable<registro> {

      
      return this.http.post<registro>(this.urlEndPoint, registros, {headers: this.httpHeaders} )

  }
}
