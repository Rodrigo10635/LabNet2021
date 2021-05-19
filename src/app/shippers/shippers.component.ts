import { Component, OnInit } from '@angular/core';
import { ShippersService } from '../Shared/shippers.service';


@Component({
  selector: 'app-shippers',
  templateUrl: './shippers.component.html',
  styleUrls: ['./shippers.component.scss']
})
export class ShippersComponent implements OnInit {
  public shippers:any=[]

  constructor(private shipperservice:ShippersService) { }

  ngOnInit(): void {
    this.shipperservice.GetAll().subscribe(res=>{this.shippers=res});
  }

  Delete(id:number)
  {
    if (confirm('¿Desea elimiar el registro?'))
    {
      this.shipperservice.delete(id).subscribe(
        res=>{
          this.shipperservice.GetAll();
        },
        error=>{
          console.log(error)
        }
      )
      
    }
    
  }

}
