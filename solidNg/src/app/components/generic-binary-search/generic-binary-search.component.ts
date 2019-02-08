import { Component, OnInit, OnDestroy } from '@angular/core';
import { BinarySearchTreeService } from 'services/index';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-generic-binary-search',
  templateUrl: './generic-binary-search.component.html',
  styleUrls: ['./generic-binary-search.component.scss']
})
export class GenericBinarySearchComponent implements OnInit, OnDestroy {
  subscription: Subscription;
  constructor(private binarySearchService: BinarySearchTreeService) { }

  ngOnInit() {
    this.subscription = this.binarySearchService.getBinarySearchTree().subscribe(data => {
      console.log(data);
    });
  }

  ngOnDestroy() {
    if (this.subscription) {
      this.subscription.unsubscribe();
    }
  }

}
