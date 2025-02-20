import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

export interface Cliente {
  id: number;
  nombre: string;
  telefono: string;
  pais: string;
}

@Injectable({
  providedIn: 'root'
})
export class ClientesService {
  private apiUrl = 'http://localhost:5072/api/clientes'; // Ajusta el puerto según tu configuración

  constructor(private http: HttpClient) { }

  getClientes(page: number = 1, pageSize: number = 12): Observable<Cliente[]> {
    return this.http.get<Cliente[]>(`${this.apiUrl}/ef?page=${page}&pageSize=${pageSize}`);
  }
}
