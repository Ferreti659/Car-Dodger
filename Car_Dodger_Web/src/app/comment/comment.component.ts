import { Component, Input, OnChanges, OnInit } from '@angular/core';

@Component({
  selector: 'comment-root',
  templateUrl: './comment.component.html',
  styleUrls: ['./comment.component.less']
})
export class CommentComponent implements OnInit {
  comments: string;
  count: number;
  constructor() { }

  ngOnInit() {
    this.count = 0;
  }

  receiveComment($event) {
    this.comments = $event;
    this.count = this.comments.length;
    console.log(this.comments.length);
  }

  recieveCount($event) {
    this.comments = $event;
    this.count = this.comments.length;
  }

}
