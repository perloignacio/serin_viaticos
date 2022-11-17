import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SolicitudesUsuarioFormComponent } from './solicitudes-usuario-form.component';

describe('SolicitudesUsuarioFormComponent', () => {
  let component: SolicitudesUsuarioFormComponent;
  let fixture: ComponentFixture<SolicitudesUsuarioFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SolicitudesUsuarioFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SolicitudesUsuarioFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
