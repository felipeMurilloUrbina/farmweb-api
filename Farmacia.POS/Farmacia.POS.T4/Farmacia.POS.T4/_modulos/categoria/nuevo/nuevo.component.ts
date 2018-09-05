import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { FormBuilder, FormGroup, FormControl } from '@angular/forms';
import { CategoriaService } from '../../../_servicios/categoria.service';
import { Categoria } from '../../../_modelos/categoria.model';
import { MensajeEstatus } from '../../../_modelos/mensaje.enum';

@Component({
  selector: 'app-nuevo-categoria',
  templateUrl: './nuevo.component.html',
  styleUrls: ['./nuevo.component.css']
})
export class NuevoCategoriaComponent implements OnInit {
  Categorias: any[];
  cols: any[];
  titulo = 'Nuevo Categoria';
  categoria: Categoria;
  constructor(private router: Router, private route: ActivatedRoute, private fb: FormBuilder, private servicio: CategoriaService) {
    this.categoria = new Categoria();
    this.route.params
      .subscribe(params => {
        if (params['id'] !== undefined) {
            this.categoria.id = params['id'];
            this.getId(params['id']);
        }
      });
  }

  ngOnInit() {
    this.get();
  }

  get() {
    if(this.categoria.id) {
        this.servicio.getId(this.categoria.id).subscribe(data => {
          this.categoria = data['item'];
        });
    }
  }
  
  limpiar() {
  }

  regresar() {
    this.router.navigate(['/admin/categorias'], { queryParams: {} });
  }

  validar() {
  }
  
  guardar() {
    this.servicio.post(this.categoria, '').subscribe( dato => {
        this.servicio.enviarMensaje(MensajeEstatus.ok, 'Categorias', dato);
        this.limpiar();
    });
  }
}
