import { ComponentFixture, TestBed } from '@angular/core/testing';

import { KendoUiComponent } from './kendo-ui.component';

describe('KendoUiComponent', () => {
  let component: KendoUiComponent;
  let fixture: ComponentFixture<KendoUiComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ KendoUiComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(KendoUiComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
