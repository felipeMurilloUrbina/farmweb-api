import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { ProductoService } from '../../../_servicios/producto.service';
import { Producto } from '../../../_modelos/producto.model';
import { MensajeEstatus } from '../../../_modelos/mensaje.enum';

@Component({
  selector: 'app-nuevo-producto',
  templateUrl: './nuevo.component.html',
  styleUrls: ['./nuevo.component.css']
})
export class NuevoProductoComponent implements OnInit {
  Productos: any[];
  cols: any[];
  titulo = 'Nuevo Producto';
  producto: Producto;
  constructor(private router: Router, private route: ActivatedRoute, private fb: FormBuilder, private servicio: ProductoService) {
    this.producto = new Producto();
    this.route.params
      .subscribe(params => {
        if (params['id'] !== undefined) {
            this.producto.id = params['id'];
            this.getId(params['id']);
        }
      });
  }

  ngOnInit() {
    this.get();
  }

  get() {
    if(this.producto.id) {
        this.servicio.getId(this.producto.id).subscribe(data => {
          this.producto = data['item'];
        });
    }
  }
  
  limpiar() {
  }

  regresar() {
    this.router.navigate(['/admin/productos'], { queryParams: {} });
  }

  validar() {
  }
  
  guardar() {
    this.servicio.post(this.producto, '').subscribe( dato => {
        this.servicio.enviarMensaje(MensajeEstatus.ok, 'Productos', dato);
        this.limpiar();
    });
  }
}
