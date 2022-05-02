import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListCastComponent } from './list-cast.component';

describe('ListCastComponent', () => {
  let component: ListCastComponent;
  let fixture: ComponentFixture<ListCastComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListCastComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(ListCastComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
