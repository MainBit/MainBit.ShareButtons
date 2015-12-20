$(function () {
    // ------------------------------------
    // share buttons
    // ------------------------------------

    // http://api.yandex.ru/share/doc/dg/concepts/share-button-ov.xml
    if (typeof Ya !== 'undefined') {
        var ya_share = $('#ya_share');
        var YaShareInstance = new Ya.share({
            element: 'ya_share',
            elementStyle: {
                type: 'none',
                quickServices: ['odnoklassniki', 'vkontakte', 'facebook', 'twitter', 'gplus', 'linkedin']
            },
            //can be override only title or link
            //serviceSpecific: {
            //    linkedin: {
            //        image: ya_share.data('yashare-linkedin-image')
            //    }
            //}
        });
    }
})