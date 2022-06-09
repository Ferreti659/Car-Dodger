import { Component, OnInit, OnDestroy  } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { CommentService } from './comment.service';
import { Route, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-comment',
  templateUrl: './comment.component.html',
  styleUrls: ['./comment.component.css']
})

export class CommentComponent implements OnInit{
  private projectId: string;

  commentForm: FormGroup;
  constructor(
    private fb: FormBuilder,
    private commentService: CommentService,
    private route: ActivatedRoute) {}

  ngOnInit() {
    this.projectId = this.route.snapshot.params.id;
    this.commentForm = this.fb.group({
      name: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      message: ['', Validators.required],
    });
  }

  onCommentCancel() {
    this.commentForm.reset();
  }

  onSubmit() {
    const content = {
      name: this.commentForm.value.name,
      email: this.commentForm.value.email,
      message: this.commentForm.value.message,
      project: this.projectId,
      postDate: Date.now()
    }
    this.commentService.addComment(content);
  }
}
