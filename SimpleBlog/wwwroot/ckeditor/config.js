/**
 * @license Copyright (c) 2003-2019, CKSource - Frederico Knabben. All rights reserved.
 * For licensing, see https://ckeditor.com/legal/ckeditor-oss-license
 */

CKEDITOR.editorConfig = function (config) {
    // Define changes to default configuration here. For example:
    // config.language = 'fr';
    // config.uiColor = '#AADC6E';
    config.filebrowserBrowseUrl = '/ckfinder/ckfinder.html';
    config.filebrowserImageBrowseUrl = '/ckfinder/ckfinder.html?type=Images';
    config.filebrowserUploadUrl = '/ckfinder/connector?command=QuickUpload&type=Files&currentFolder=/wwwroot/img/postImage/';
    config.filebrowserImageUploadUrl ='/ckfinder/connector?command=QuickUpload&type=Images&currentFolder=/wwwroot/img/postImage/';
};
CKFinder.setupCKEditor(null, '/ckfinder/');
