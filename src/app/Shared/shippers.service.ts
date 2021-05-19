import { Injectable } from '@angular/core';
import{HttpClient} from '@angular/common/http'
import { Observable } from 'rxjs';
import {Shippers} from './shippers.model'

const Url='https://localhost:44363/api/Shippers'
@Injectable({
  providedIn: 'root'
})
export class ShippersService {

  constructor(private http: HttpClient) { }
  formData:Shippers = new Shippers();


GetAll(): Observable<Shippers>
{
  return this.http.get<Shippers>(Url);
}

delete(id:number)
  {
    return this.http.delete(`${Url}/${id}` );
  }

  

}
