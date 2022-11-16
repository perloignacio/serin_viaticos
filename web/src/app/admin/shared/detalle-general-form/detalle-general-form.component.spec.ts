import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DetalleGeneralFormComponent } from './detalle-general-form.component';

describe('DetalleGeneralFormComponent', () => {
  let component: DetalleGeneralFormComponent;
  let fixture: ComponentFixture<DetalleGeneralFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DetalleGeneralFormComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DetalleGeneralFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
