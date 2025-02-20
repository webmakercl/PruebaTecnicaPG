import { Component, OnInit } from '@angular/core';
import { ClientesService, Cliente } from '../clientes.service';

@Component({
  selector: 'app-clientes',
  standalone: false,
  templateUrl: './clientes.component.html',
  styleUrls: ['./clientes.component.css']
})
export class ClientesComponent implements OnInit {
  clientes: Cliente[] = [];

  constructor(private clientesService: ClientesService) { }

  ngOnInit(): void {
    this.cargarClientes();
  }

  cargarClientes(page: number = 1, pageSize: number = 12): void {
    this.clientesService.getClientes(page, pageSize).subscribe(data => {
      this.clientes = data;
    });
  }
}


