(window.webpackJsonp=window.webpackJsonp||[]).push([[0],{19:function(e,t,n){e.exports=n(34)},24:function(e,t,n){},30:function(e,t,n){},34:function(e,t,n){"use strict";n.r(t);var a=n(1),o=n.n(a),r=n(4),c=n.n(r),s=(n(24),n(5)),i=n.n(s),l=n(18),u=n(11),p=n(6),d=n(7),h=n(9),m=n(8),f=n(10),v=n(3),N=function(e){function t(){var e,n;Object(p.a)(this,t);for(var a=arguments.length,o=new Array(a),r=0;r<a;r++)o[r]=arguments[r];return(n=Object(h.a)(this,(e=Object(m.a)(t)).call.apply(e,[this].concat(o)))).state={editMode:!1,noteText:n.props.note.noteText},n.editNote=function(e){console.log("edit note",n.state.noteText),n.setState({editMode:!n.state.editMode},function(e){n.state.editMode||n.props.updateNote(n.props.id,n.state.noteText)})},n.noteChange=function(e){n.setState({noteText:e.target.value})},n.completeNote=function(e){console.log("complete note")},n}return Object(f.a)(t,e),Object(d.a)(t,[{key:"render",value:function(){var e=this.state.editMode?o.a.createElement(v.f,{value:this.state.noteText,onChange:this.noteChange}):o.a.createElement(v.e,null,this.props.note.noteText),t=this.state.editMode?"done":"edit";return o.a.createElement(v.c,{className:"note"},o.a.createElement(v.d,null,o.a.createElement(v.i,{href:"#",onClick:this.completeNote},"Complete"),o.a.createElement(v.i,{href:"#",onClick:this.editNote},t),e))}}]),t}(a.PureComponent),g=(n(30),"".concat("","/api/notes/")),E=function(e){function t(){var e,n;Object(p.a)(this,t);for(var a=arguments.length,o=new Array(a),r=0;r<a;r++)o[r]=arguments[r];return(n=Object(h.a)(this,(e=Object(m.a)(t)).call.apply(e,[this].concat(o)))).state={notes:[],newNote:"",updated:!1},n.fetchNotes=function(e){fetch(g).then(function(e){return e.json()}).then(function(e){console.log(e),n.setState({notes:e})})},n.noteChange=function(e){var t=e.target.value;n.setState({newNote:t})},n.updateNote=function(){var e=Object(u.a)(i.a.mark(function e(t,a){var o,r,c,s;return i.a.wrap(function(e){for(;;)switch(e.prev=e.next){case 0:return o=n.state.notes.map(function(e){return e.noteID===t?Object(l.a)({},e,{noteText:a}):e}),n.setState({notes:o}),r=g+t,console.log(r),c={NoteText:a},e.next=7,fetch(r,{method:"PUT",headers:{Accept:"application/json","Content-Type":"application/json"},body:JSON.stringify(c)});case 7:(s=e.sent).ok?console.log("ALL GOOD!"):console.log("Error",s.statusText);case 9:case"end":return e.stop()}},e,this)}));return function(t,n){return e.apply(this,arguments)}}(),n.insertNote=function(){var e=Object(u.a)(i.a.mark(function e(t){var a,o;return i.a.wrap(function(e){for(;;)switch(e.prev=e.next){case 0:return a={NoteText:n.state.newNote},e.next=3,fetch(g,{method:"POST",headers:{Accept:"application/json","Content-Type":"application/json"},body:JSON.stringify(a)});case 3:(o=e.sent).ok?(n.setState({updated:!0}),n.fetchNotes()):n.setState({error:o.statusText});case 5:case"end":return e.stop()}},e,this)}));return function(t){return e.apply(this,arguments)}}(),n}return Object(f.a)(t,e),Object(d.a)(t,[{key:"componentDidMount",value:function(){this.fetchNotes()}},{key:"render",value:function(){var e=this,t=this.state.notes.map(function(t){return o.a.createElement(N,{id:t.noteID,key:t.noteID,note:t,updateNote:e.updateNote})});return o.a.createElement("div",{className:"App"},o.a.createElement("div",{className:"container"},o.a.createElement("header",null,"Scratch"),this.state.updated?o.a.createElement(v.a,{color:"success"},"Note Added"):null,this.state.error?o.a.createElement(v.a,{color:"danger"},this.state.error):null,o.a.createElement("p",null),o.a.createElement(v.g,null,o.a.createElement(v.f,{onChange:this.noteChange,value:this.state.newNote,placeholder:"Enter a new note and click 'Save'"}),o.a.createElement(v.h,{addonType:"append"},o.a.createElement(v.b,{onClick:this.insertNote,color:"primary"},"Save"))),o.a.createElement("p",null),o.a.createElement("h3",{className:"text-center"},"Notes"),o.a.createElement("div",{className:"note-list text-center"},t.length?t:o.a.createElement("div",null,"No notes"))))}}]),t}(a.Component);Boolean("localhost"===window.location.hostname||"[::1]"===window.location.hostname||window.location.hostname.match(/^127(?:\.(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)){3}$/));n(32);c.a.render(o.a.createElement(E,null),document.getElementById("root")),"serviceWorker"in navigator&&navigator.serviceWorker.ready.then(function(e){e.unregister()})}},[[19,2,1]]]);
//# sourceMappingURL=main.7191f430.chunk.js.map