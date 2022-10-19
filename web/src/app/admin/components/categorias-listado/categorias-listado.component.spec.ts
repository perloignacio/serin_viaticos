import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CategoriasListadoComponent } from './categorias-listado.component';

describe('CategoriasListadoComponent', () => {
  let component: CategoriasListadoComponent;
  let fixture: ComponentFixture<CategoriasListadoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CategoriasListadoComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CategoriasListadoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
