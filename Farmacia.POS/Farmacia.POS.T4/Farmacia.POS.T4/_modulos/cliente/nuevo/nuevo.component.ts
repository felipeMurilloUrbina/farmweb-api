import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { ClienteService } from '../../../_servicios/cliente.service';
import { Cliente } from '../../../_modelos/cliente.model';
import { MensajeEstatus } from '../../../_modelos/mensaje.enum';

@Component({
  selector: 'app-nuevo-cliente',
  templateUrl: './nuevo.component.html',
  styleUrls: ['./nuevo.component.css']
})
export class NuevoClienteComponent implements OnInit {
  Clientes: any[];
  cols: any[];
  titulo = 'Nuevo Cliente';
  cliente: Cliente;
  constructor(private router: Router, private route: ActivatedRoute, private fb: FormBuilder, private servicio: ClienteService) {
    this.cliente = new Cliente();
    this.route.params
      .subscribe(params => {
        if (params['id'] !== undefined) {
            this.cliente.id = params['id'];
            this.getId(params['id']);
        }
      });
  }

  ngOnInit() {
    this.get();
  }

  get() {
    if(this.cliente.id) {
        this.servicio.getId(this.cliente.id).subscribe(data => {
          this.cliente = data['item'];
        });
    }
  }
  
  limpiar() {
  }

  regresar() {
    this.router.navigate(['/admin/clientes'], { queryParams: {} });
  }

  validar() {
  }
  
  guardar() {
    this.servicio.post(this.cliente, '').subscribe( dato => {
        this.servicio.enviarMensaje(MensajeEstatus.ok, 'Clientes', dato);
        this.limpiar();
    });
  }
}
